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
    [XmlType("Element")]
    [XmlInclude(typeof(Circle)), XmlInclude(typeof(Dot)), XmlInclude(typeof(Rectangle))] 
    public abstract class Element
    {
        private System.Drawing.Color rgbColor;
        private Coordinates position;
        public abstract void Draw(System.Drawing.Graphics g);

        [XmlElement("Position")]
        public Coordinates Position
        {
            get { return position; }
            set { position = value; }
        }

        [XmlIgnoreAttribute()]
        public System.Drawing.Color RgbColor
        {
            get { return rgbColor; }
            set { rgbColor = value; }
        }

        // Trick to serialize the color :)
        [XmlElement("Color")]
        public string RgbColorHtml
        {
            get
            {
                return
                    ColorTranslator.ToHtml(rgbColor);
            }
            set
            {
                rgbColor = ColorTranslator.FromHtml(value);
            }
        }

        protected Element(Coordinates position, System.Drawing.Color rgbColor)
        {
            Position = position; //using properties
            RgbColor = rgbColor;
        }

        // Default constructor: black element in origo
        protected Element()
            : this(new Coordinates(), System.Drawing.Color.Black)
        {
        }


        public override string ToString()
        {
            return this.GetType().ToString() + ": " //Class name
            + Position.ToString() + ", " + //Coorninates
            RgbColor.ToString(); //color
        }

        // Virtual function should be overriden by all derived classes
        public virtual bool IsOnCanvas(System.Drawing.RectangleF r)
        {
            return true;
        }
    }
}
