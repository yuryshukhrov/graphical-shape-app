using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Utils
{
    [Serializable]
    [XmlRoot("Elements")]
    [XmlInclude(typeof(Element))] // include type class Element
    public sealed class Picture
    {
        
        private List<Element> elements = new List<Element>();
        private string name;
        // This event will be raised when element exceeds canvas area.
        // public event EventHandler CanvasExceededEventHandler;

        [XmlArray("ElementArray")]
        [XmlArrayItem("ElementObject")]
        public List<Element> Elements
        {
            get { return this.elements; }
            set { this.elements = value; }
        }

        [XmlElement("Name")]
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                    name = value;
                else
                    name = string.Empty;
            }
        }

        public Picture()
        {
            
        }

        public Picture(string name)
        {
            Name = name;
        }


        /* Draws all the elements in this picture.
            CanvasExceeded Event is raised, if any of elements
            exceeds the canvas area */

        public void DrawAll(System.Drawing.Graphics g, System.Drawing.RectangleF r,
           System.Windows.Forms.ToolStripStatusLabel tsLabel)
        {
            //if any element exceeds the canvasarea, this flag is set
            bool exceeded = false;

            g.DrawString("Picture Name: " + Name, new Font("Arial", 10), 
                Brushes.Red, new Point(0, 0));

            foreach (Utils.Element e in Elements)
            {
                e.Draw(g);

                //Did this element did not exceeded the canvas area
                if (!e.IsOnCanvas(r))
                    exceeded = true;
            }

            //Should event be raised?
            //if (exceeded && CanvasExceededEventHandler != null)
            //    CanvasExceededEventHandler(this, EventArgs.Empty);

            if (exceeded)
                tsLabel.Text = "Canvas exceeded";
            else
                tsLabel.Text = "";
        }

        // Overloaded
        public void DrawAll(System.Drawing.Graphics g)
        {
            //Name of the picture
            g.DrawString("Picture Name: " + Name, new Font("Arial", 10),
                Brushes.Red, new Point(0, 0));

            foreach (Utils.Element e in Elements)
            {
                e.Draw(g);
            }
        }

        public void ZoomPlus()
        {
            foreach (Utils.Element e in Elements)
            {
                Utils.IZoom zoom = e as Utils.IZoom;
                //Does this element implement IZoom?
                if (zoom != null)
                    zoom.Increase();
            }
        }

        public void ZoomMinus()
        {
            foreach (Utils.Element e in Elements)
            {
                Utils.IZoom zoom = e as Utils.IZoom;
                //Does this element implement IZoom?
                if (zoom != null)
                    zoom.Decrease();
            }
        }

        /* Method moves all elements in picture with given offset */
        public void Move(Coordinates movedCoords)
        {
            foreach (Utils.Element e in Elements)
            {
                e.Position += movedCoords;
            }
        }
    }
}
