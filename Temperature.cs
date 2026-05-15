using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Final_Group_Project
{
    internal class Temperature
    {
        // attributes
        private int temp;

        // constructor
        public Temperature(int temp)
        {
            this.temp = temp;
        }

        // properties
        public int Temp
        {
            get { return temp; }
            set { temp = value; }
        }

        // ToString() override
        public override string ToString()
        {
            return "Temperature: " + temp + " F";
        }

        ~Temperature() { }
    }
}
