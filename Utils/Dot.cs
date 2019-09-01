using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Utils
{
    [Serializable]
    [XmlType("Dot")]
    public class Dot : Element
    {
        public Dot()
            : base()
        {
        }
        public Dot(Coordinates position, System.Drawing.Color rgbColor)
            : base(position, rgbColor)
        {
        }


        /* Draws a pixel (3x3 rectangular) to coordinates Position.X & .Y
            using given color */
        
        public override void Draw(System.Drawing.Graphics g)
        { //Create pen
            using (System.Drawing.Pen p = new System.Drawing.Pen(RgbColor))
            {
                //draw a pixel (small rectangular)
                g.DrawRectangle(p, Position.X, Position.Y, 3, 3);
            } // pen is disposed
        }

        public override bool IsOnCanvas(System.Drawing.RectangleF r)
        {
            System.Drawing.RectangleF newrec = new System.Drawing.RectangleF(
                Position.X, Position.Y, 3, 3);

            return r.Contains(newrec);
        }
    }
}
