using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uif
{
    public partial class Layout : Form
    {
        private Utils.Picture pict;
        //for printing, setupt and preview
        private PrintPreviewDialog Pv;
        private PageSetupDialog Ps;
        private PrintDocument Pd;
        private PrintDialog Pr;

        public Utils.Picture Pict
        {
            get { return pict; }
            set { pict = value; }
        }

        public Layout()
        {
            InitializeComponent();

            //For printing purposes
            Pv = new PrintPreviewDialog();
            Ps = new PageSetupDialog();
            Pr = new PrintDialog();
            Pd = new PrintDocument();
            //Name the printed document (shown in Printer queue window)
            Pd.DocumentName = "Graphical Shape Application: Layout View";
            //Connect dialogs to this printed document
            Pv.Document = Pd;
            Ps.Document = Pd;
            Pr.Document = Pd;
        }

        private void readClipboard()
        {
            //Data available in clipboard
            if (Clipboard.ContainsData("data"))
            {
                //Read a picture object from clipboard
                DataObject dataObject = (DataObject)Clipboard.GetDataObject();
                //Casting to Picture type
                Pict = (Utils.Picture)dataObject.GetData("data");
                if (Pict != null)
                {
                    pbxPastedPicture.Invalidate();
                }
            }
        }

        private void Layout_Resize(object sender, EventArgs e)
        {
            //Invalidate() Causes call of pbxPastedPicture_Paint() method
            pbxPastedPicture.Invalidate();
        }

        private void Layout_Load(object sender, EventArgs e)
        {
            // This method is called as soon as the frame loads (shows up)
            readClipboard();
            Pd.PrintPage += new PrintPageEventHandler(this.pd_Print);
        }

        private void pbxPastedPicture_Paint(object sender, PaintEventArgs e)
        {
            if (Pict != null)
            {
                Pict.DrawAll(e.Graphics);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Right type of data available in clipboard?
            if (Clipboard.ContainsData("data"))
            {
                //read clipboard
                readClipboard();
            }
            else
            {
                MessageBox.Show("No new picture elements available");
            }
        }

        private void pd_Print(object sender, PrintPageEventArgs ep)
        {
            Font oFont = new Font("Arial", 10);
            Rectangle marginRect = ep.MarginBounds;
            //Draw bottom text
            ep.Graphics.DrawString("Graphical Shape Application " +
                "@ 2013 Yuri Shukhrov", oFont, new
            SolidBrush(System.Drawing.Color.Green),
            (ep.MarginBounds.Left+150), ep.PageBounds.Bottom - 60);
            //Draw Graphics on ep
            if (Pict != null)
            {
                Pict.DrawAll(ep.Graphics);
            }
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Setting default paper size to A4
            PaperSize size = new PaperSize();
            size.RawKind = (int)PaperKind.A4;
            Ps.PageSettings.PaperSize = size;
            Ps.ShowDialog();
            // Copying setting from page setup dialog to printer settings
            Pd.DefaultPageSettings = Ps.PageSettings;
            Pd.PrinterSettings = Ps.PrinterSettings;
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pv.WindowState = FormWindowState.Maximized;
            Pv.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Pr.ShowDialog() == DialogResult.OK)
                //Raise event
                Pd.Print();
        }
    }
}
