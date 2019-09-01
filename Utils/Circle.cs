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
    [XmlType("Circle")]
    public class Circle : Element, IZoom, IArea
    {

        private int radius;

        /* Radius must be positive. If negative value is given,
         radius is set to 20 */

        [XmlElement("Radius")]
        public int Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                    radius = value;
                else
                    radius = 20;
            }
        }

        /* Default radius is 20 */
        public Circle()
            : base()
        {
            Radius = 20;
        }

        public Circle(Coordinates position, System.Drawing.Color rgbColor, int
        radius)
            : base(position, rgbColor)
        {
            Radius = radius;
        }

        /* Draws a circle with given raidus, coordinates Position.X & .Y
         using given color) */

        public override void Draw(System.Drawing.Graphics g)
        {
            // Create a pen
            System.Drawing.Pen p = new System.Drawing.Pen(RgbColor);
            int x = Position.X - Radius;
            int y = Position.Y - Radius;
            int width = Radius * 2;
            int height = Radius * 2;

            // Draw an eclipse
            g.DrawEllipse(p, x, y, width, height);

        }

        public override string ToString()
        {
            return base.ToString() + ", radius " + Radius;
        }

        // Increases radius by 10%
        public void Increase()
        {
            Radius = (int)(Radius * 1.1);
        }

        // Decreases radius by 10%
        public void Decrease()
        {
            Radius = (int)(Radius * 0.9);
        }

        // Area = Pii*r*r
        public double Area
        {
            get { return Math.PI * ((double)Radius * (double)Radius); }
        }

    
        // Does this circle fit into canvas area? 
        public override bool IsOnCanvas(System.Drawing.RectangleF r)
        {
            System.Drawing.RectangleF newrec = new System.Drawing.RectangleF(
                Position.X - Radius, Position.Y - Radius, 2 * Radius, 2 * Radius);

            return r.Contains(newrec);   
        }
    }
}
