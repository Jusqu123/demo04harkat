using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4tehtävä1
{
    class Elevator
    {

        //Max floor
        private readonly int maxFloor = 5;
        private readonly int MinFloor = 0;
        //member field
        private int floor; // huom floor on pienellä
        // property
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= maxFloor) floor = value;
                else
                {
                    Console.WriteLine("out of bounds you rebel bastard");
                    floor = maxFloor;
                }
            }
        }
    }
}
            
        

