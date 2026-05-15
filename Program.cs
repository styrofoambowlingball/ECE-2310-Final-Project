using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Final_Group_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // printing num of pools before instantiating
            int loc = 0;
            const int size = 7;
            Console.WriteLine("===== Counting the Number of Pools =====\n");
            Console.WriteLine("There are " + Pool.Count + " pools.\n");
            // instantiating pools and cleaner and printing the count after each pool
            Pool[] pools = new Pool[size];
            Cleaner cleaner = new Cleaner(0, 0);
            pools[0] = new Pool(4, 8, 90, "A");
            Console.WriteLine(pools[0].ToString());
            Console.WriteLine("There is now " + Pool.Count + " pool.\n");
            pools[1] = new Pool(1, 3, 90, "B");
            Console.WriteLine(pools[1].ToString());
            Console.WriteLine("There are now " + Pool.Count + " pools.\n");
            pools[2] = new Pool(4, 2, 90, "C");
            Console.WriteLine(pools[2].ToString());
            Console.WriteLine("There are now " + Pool.Count + " pools.\n");
            pools[3] = new Pool(13, 1, 90, "D");
            Console.WriteLine(pools[3].ToString());
            Console.WriteLine("There are now " + Pool.Count + " pools.\n");
            pools[4] = new Pool(12, 9, 90, "E");
            Console.WriteLine(pools[4].ToString());
            Console.WriteLine("There are now " + Pool.Count + " pools.\n");
            pools[5] = new Pool(10, 5, 90, "F");
            Console.WriteLine(pools[5].ToString());
            Console.WriteLine("There are now " + Pool.Count + " pools.\n");
            pools[6] = new Pool(6, 6, 90, "G");
            Console.WriteLine(pools[6].ToString());
            Console.WriteLine("There are now " + Pool.Count + " pools.");

            Console.WriteLine("\n===== Cleaning the Pools ====="); // programming cleaner to clean the pools

            for (int i = 0; i < size; i++) // loop to clean every pool
            {
                double ShortestDist = 100;
                for (int j = 0; j < size; j++) // loop to locate the closest pool
                {
                    if (ShortestDist > cleaner.LocatePoolDistance(pools[j]))
                    {
                        ShortestDist = cleaner.LocatePoolDistance(pools[j]);
                        loc = j;
                    }
                }
                cleaner.CleanerLocation.xLoc = pools[loc].PoolLocation.xLoc;
                cleaner.CleanerLocation.yLoc = pools[loc].PoolLocation.yLoc;
                cleaner.CleanPool(pools[loc]);
                Console.WriteLine(pools[loc].ToString());
                Console.Write(cleaner.CleanerPath(pools[loc]));
            }

            Console.Read();
        }
    }
}
