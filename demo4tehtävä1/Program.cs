using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
                    int number = 0;
            elevator.Floor = number;
            Console.Write("Give a floor number > ");
            string line = Console.ReadLine();

        

            do
            {
                Console.WriteLine("Number was " + number);
                bool result = int.TryParse(line, out number);



                Console.WriteLine("Number was " + number);

         
                Console.WriteLine("*Elevator music* going to floor : " + elevator.Floor);
                Console.ReadLine();
                Console.WriteLine("Floor number is now " + number);
            } while (number != -1);

        }
    }
}




//do {
// kysy kerros
//siirrä hissiä jos mahdollista
//tulosta missä hissi on



//}while (floor != 0)