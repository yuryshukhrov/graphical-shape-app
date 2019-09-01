using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uif
{
    public partial class Navigator : Form
    {
        StartForm sf;

        public StartForm Sf
        {
            set { sf = value; }
        }

        public Navigator(StartForm sf)
        {
            InitializeComponent();
            Sf = sf;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void moveClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //Tag values have ; as separator
            string btb_tag = btn.Tag.ToString();
            string[] parts = btb_tag.Split(';');

            if (parts.Length != 2)
            {
                MessageBox.Show("Tag value in button is incorrect");
            }

            else
            {
                int x = int.Parse(parts[0]);
                int y = int.Parse(parts[1]);
                Utils.Coordinates movedCoords = new Utils.Coordinates(x, y);
                sf.Pict.Move(movedCoords);
                //PbxOutput property was created to get Invalidate() visible too
                sf.PbxOutput.Invalidate();
            }        
        }
    }
}
