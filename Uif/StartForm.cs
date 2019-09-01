using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uif
{
    public partial class StartForm : Form
    {
        Utils.Picture pict;

        Navigator navi;
      
        public Utils.Picture Pict
        {
            get { return pict; }
            set { pict = value; }
        }

        public StartForm()
        {
            InitializeComponent();
            Pict = new Utils.Picture("Default");
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            Utils.Coordinates defXY = new Utils.Coordinates();
            lbxOutput.Items.Add(defXY.ToString());
        }

        private void btnGiven_Click(object sender, EventArgs e)
        {
            int a, b;
            // Object is created only if given coordinates
            // are parsed to integer values.
            if (int.TryParse(tbxX.Text, out a))
            {
                if (int.TryParse(tbxY.Text, out b))
                {
                    Utils.Coordinates defXY = new Utils.Coordinates(a, b);
                    lbxOutput.Items.Add(defXY.ToString());
                }
            }
        }

        private void llbRunGC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GC.Collect();
        }

        private void llbNumberOfInstances_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbxOutput.Items.Add("Number of Coordinate Instances is " +
            Utils.Coordinates.NumberOfInstances);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;
                btnColor.BackColor = selectedColor;
            }
        }

        private void llbDot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int a, b;
            // Object is created only if given coordinates
            // are parsed to integer values.
            if (int.TryParse(tbxX.Text, out a))
            {
                if (int.TryParse(tbxY.Text, out b))
                {
                    //Color is button's backcolor
                    Color c = btnColor.BackColor;
                    //Create a dot and print it's data on list box
                    Utils.Dot d = new Utils.Dot(
                    new Utils.Coordinates(a, b), c);
                    lbxOutput.Items.Add(d.ToString());
                    //Draw 3x3 rectangular to Picture Box
                    //d.Draw(pbxOutput.CreateGraphics());

                    Pict.Elements.Add(d);
                    //Invalidate causes automatically Paint-event
                    pbxOutput.Invalidate();
                }
            }
        }

        private void llbCircle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int a, b, r;
            // Object is created only if given coordinates and radius
            // are parsed to integer values.
            if (int.TryParse(tbxX.Text, out a))
            {
                if (int.TryParse(tbxY.Text, out b))
                {
                    if (int.TryParse(tbxRadius.Text, out r))
                    {
                        // Color is button's backcolor
                        Color c = btnColor.BackColor;
                        // Create a circle and print it's data on list box
                        Utils.Circle d = new Utils.Circle(
                        new Utils.Coordinates(a, b), c, r);
                        lbxOutput.Items.Add(d.ToString());
                        // Draw 3x3 rectangular to Picture Box
                        //d.Draw(pbxOutput.CreateGraphics());
                        Pict.Elements.Add(d);
                        //Invalidate causes automatically Paint-event
                        pbxOutput.Invalidate();
                    }
                }
            }
        }

        private void llbRectangle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int a, b, w, h;
            // Object is created only if given coordinates, width and height
            // are parsed to integer values.
            if (int.TryParse(tbxX.Text, out a))
            {
                if (int.TryParse(tbxY.Text, out b))
                {
                    if (int.TryParse(tbxWidth.Text, out w))
                    {
                        if (int.TryParse(tbxHeight.Text, out h))
                        {
                            // Color is button's backcolor
                            Color c = btnColor.BackColor;
                            // Create a rectangle and print it's data on list box
                            Utils.Rectangle d = new Utils.Rectangle(
                            new Utils.Coordinates(a, b), c, w, h);
                            lbxOutput.Items.Add(d.ToString());
                            // Draw 3x3 rectangular to Picture Box
                            //d.Draw(pbxOutput.CreateGraphics());
                            Pict.Elements.Add(d);
                            //Invalidate causes automatically Paint-event
                            pbxOutput.Invalidate();
                        }
                    }
                }
            }
        }

        private void pbxOutput_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel.Text = string.Empty;
            Pict.DrawAll(e.Graphics, e.ClipRectangle, toolStripStatusLabel);
        }

        private void btnPictureData_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            lbxOutput.Items.Add("Picture: " + Pict.Name);
            lbxOutput.Items.Add("Number of elements " + Pict.Elements.Count);
            foreach (Utils.Element el in Pict.Elements)
            {
                lbxOutput.Items.Add(el.ToString());
                //Does element implement interface IArea
                Utils.IArea a = el as Utils.IArea;
                //Dot is not implementin IArea, must be tested
                if (a != null)
                {
                    lbxOutput.Items.Add(" area = " + a.Area);
                }
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            Pict.ZoomPlus();
            pbxOutput.Invalidate();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            Pict.ZoomMinus();
            pbxOutput.Invalidate();
        }

        private void picture_CanvasExceededEventHandler(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = "Canvas exceeded";
        }

        private void pbxOutput_Resize(object sender, EventArgs e)
        { //Redraw objects when window is resized
            pbxOutput.Invalidate();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            //Pict.CanvasExceededEventHandler += new
            //EventHandler(picture_CanvasExceededEventHandler);
        }

        private void btnNavigator_Click(object sender, EventArgs e)
        {
            navi = new Navigator(this);
            navi.Show();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save Picture Files";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = ".xml";
            // Set filter options and filter index.
            saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            // Process input if the user clicked OK.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                var sections = filePath.Split('\\');
                string fileName = sections[sections.Length - 1];
                Pict.Name = fileName;
                Utils.FileIO.WriteToFile(filePath, Pict);
                pbxOutput.Invalidate();                
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pict = new Utils.Picture("NewPicture");
            pbxOutput.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.DefaultExt = ".xml";
            openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Open Picture Files";
            openFileDialog1.Multiselect = true;
            openFileDialog1.FilterIndex = 1;

            // Process input if the user clicked OK.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                Pict = Utils.FileIO.ReadFromFile(fileName);
                pbxOutput.Invalidate();               
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Edit – Copy menu
            DataObject dataObject = new DataObject();
            //Add Pict-object to DataObject
            //Pict –object is already Serializable
            dataObject.SetData("data", Pict);
            //Write DataObject to clipboard
            Clipboard.SetDataObject(dataObject);
        }

        private void layoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Copy picture object to clipboard
            DataObject dataObject = new DataObject();
            //Add Pict-object to DataObject
            dataObject.SetData("data", Pict);
            //Write DataObject to clipboard
            Clipboard.SetDataObject(dataObject);
            //Show Layout form
            Layout layout = new Layout();
            layout.Show();
        }

        private void aboutCSharpSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }

        private void helpContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm"); 
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("updater.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.ProductVersion.ToString());
        }
    }
}
