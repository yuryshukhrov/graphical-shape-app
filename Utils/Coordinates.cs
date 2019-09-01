using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Utils
{
    [Serializable]
    [XmlRoot("Coordinates")]
    public class Coordinates
    {

        // X coordinate (integer)
        private int x;

        // Y coordinate (integer)
        private int y;

        // Counter for created instances
        private static int numberOfInstances = 0;


        // Static property NumberOfInstances
        public Coordinates(int x, int y)
        {
            X = x;  //Use properties
            Y = y;  // If no property is available, then use field this.x=x;
            string objectID = this.GetHashCode().ToString();
            string message = this.ToString();
            System.Diagnostics.Trace.WriteLine("Constructor of " + message  + ", " + objectID);
            Coordinates.NumberOfInstances++;
        }


        /* Default constructor sets coordinates to origo.
           Coordinates are set by calling the complete constructor. */

        public Coordinates() : this(0, 0) {}
     
        ~Coordinates()
        {
            string objectID = this.GetHashCode().ToString();
            string message = this.ToString();
            System.Diagnostics.Trace.WriteLine("Destructor of " + message + ", " + objectID);
            Coordinates.NumberOfInstances--;
        }

        static public int NumberOfInstances
        {
            get { return Coordinates.numberOfInstances; }
            //Set is visible only in this class
            //static member can use other static member
            private set { Coordinates.numberOfInstances = value; }
        }
  
        
        /* Properties for coordinates,
           Accepted range is -999 ... 999. If range is exceeded, 
           the value is restricted. */

        public int X
        {
            get { return x; }
            set
            {
                if (value < -999)
                    x = -999;
                else if (value > 999)
                    x = 999;
                else
                    x = value;
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                if (value < -999)
                    y = -999;
                else if (value > 999)
                    Y = 999;
                else
                    y = value;
            }
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }

        // Moves coordinates adding given offset
        public static Coordinates operator +(Coordinates c1, Coordinates c2)
        {
            return new Coordinates(c1.X + c2.X, c1.Y + c2.Y);
        }

        /* Overloaded minus (-) operator is not used in this task, but is created as an example.
        Moves coordinates subtracting given offset */    
        public static Coordinates operator -(Coordinates c1, Coordinates c2)
        {
            return new Coordinates(c1.X - c2.X, c1.Y - c2.Y);
        }
    }
}
