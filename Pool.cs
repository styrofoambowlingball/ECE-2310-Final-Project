using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Final_Group_Project
{
    internal class Pool
    {
        // attributes
        private Temperature temp;
        private Location location;
        private string name;
        public bool clean;
        public static int Count = 0;

        // constructor
        public Pool(double x, double y, int temperature, string PoolName)
        {
            temp = new Temperature(temperature);
            location = new Location(x, y);
            clean = false;
            Count++;
            name = PoolName;
        }

        // properties
        public Temperature PoolTemperature
        {
            get { return temp; }
            set { temp = value; }
        }

        public Location PoolLocation
        {
            get { return location; }
            set { location = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool Clean
        {
            get { return clean; }
            set { clean = value; }
        }

        // ToString override
        public override string ToString()
        {
            return "Pool Name: " + name + "\nPool Location: " + location.ToString() + "\n" + temp.ToString() + "\n";
        }

        ~Pool() { }
    }
}
