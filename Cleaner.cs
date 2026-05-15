using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Final_Group_Project
{
    internal class Cleaner
    {
        // attributes
        private Location location;
        string path = "(0,0) ";
        Random r = new Random();

        // constructor
        public Cleaner(double x, double y)
        {
            location = new Location(x, y);
        }
        // properties
        public Location CleanerLocation
        {
            get { return location; }
            set { location = value; }
        }

        // cleaner functions
        public double LocatePoolDistance(Pool pool) // function that gets pool distance from cleaner and returns its value
        {
            if (!pool.clean) // first check if pool is not already cleaned
            {
                double distance = 0;
                distance = Math.Sqrt(Math.Pow((Math.Abs(pool.PoolLocation.xLoc - CleanerLocation.xLoc)), 2) + Math.Pow((Math.Abs(pool.PoolLocation.yLoc - CleanerLocation.yLoc)), 2));
                return distance;
            }
            return 100;
        }

        public void CleanPool(Pool pool) // function that cleans pool and changes temp
        {
            if (pool.PoolLocation.xLoc == CleanerLocation.xLoc && pool.PoolLocation.yLoc == CleanerLocation.yLoc && !pool.clean) // cleaner must be at pool location and pool must not be already cleaned
            {
                pool.PoolTemperature.Temp = r.Next(98, 104);
                Console.WriteLine("\nSet Pool " + pool.Name + " to temperature " + pool.PoolTemperature.Temp + " degrees F\n");
                pool.Clean = true;
            }
        }

        public string CleanerPath(Pool pool) // updates the cleaner path giving pool name and its temp
        {
            path += ">> " + pool.Name + " with temperature at " + pool.PoolTemperature.Temp + " degrees F. \n";
            return path;
        }

        ~Cleaner() { }
    }
}
