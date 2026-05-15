using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Final_Group_Project
{
    internal class Location
    {
        // attributes
        private double x;
        private double y;

        // constructor
        public Location(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // properties
        public double xLoc
        {
            get { return x; }
            set { x = value; }
        }

        public double yLoc
        {
            get { return y; }
            set { y = value; }
        }

        // ToString override
        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }

        ~Location() { }
    }
}
