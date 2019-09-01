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
    [XmlType("Rectangle")]
    public class Rectangle : Element, IZoom, IArea
    {

        private int width;
        private int height;

        /* Width must be positive. If negative value is given,
         width is set to 40 */

        [XmlElement("Width")]
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
                else
                    width = 40;
            }
        }

        /* Height must be positive. If negative value is given,
         height is set to 40 */

        [XmlElement("Heigth")]
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                    height = value;
                else
                    height = 20;
            }
        }

        /* Default width is 40 and height is 20 */

        public Rectangle()
            : base()
        {
            Width = 40;
            Height = 20;
        }


        public Rectangle(Coordinates position, System.Drawing.Color rgbColor, int
        width, int height)
            : base(position, rgbColor)
        {
            Width = width;
            Height = height;
        }


        /* Draws a ractangle with given sides, coordinates Position.X & .Y
         using given color) */

        public override void Draw(System.Drawing.Graphics g)
        {
            // Create a pen
            System.Drawing.Pen p = new System.Drawing.Pen(RgbColor);
            int x = Position.X;
            int y = Position.Y;

            // Draw a rectangle
            g.DrawRectangle(p, x, y, Width, Height);
            g.Flush();
        }

        public override string ToString()
        {
            return base.ToString() + ", width " + Width + ", height " + Height;
        }

        public void Increase()
        {
            Height = (int)(Height * 1.1);
            Width = (int)(Width * 1.1);
        }

        public void Decrease()
        {
            Height = (int)(Height * 0.9);
            Width = (int)(Width * 0.9);
        }

        public double Area
        {
            get { return (double)Height * (double)Width; }
        }

        public override bool IsOnCanvas(System.Drawing.RectangleF r)
        {
            System.Drawing.RectangleF newrec = new System.Drawing.RectangleF(
                Position.X, Position.Y, Width, Height);

            return r.Contains(newrec);
        }
    }
}
