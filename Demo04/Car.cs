using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Car
    {
        //Max speed
        private readonly int maxSpeed = 200;
        //member field
        private int speed; // huom speed on pienellä
        // property
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value <= maxSpeed) speed = value;
                else
                {
                    Console.WriteLine("Too much speed you maniac");
                    speed = maxSpeed;
                }
            }
        }
       
    }
}
