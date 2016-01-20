using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.FirstName = "Damn";
            person.LastName = "Dude";
            person.Age = 18;
            person.Address = "damdudestreet 9";
            person.PhoneNumber = "687534387";
            Console.WriteLine(person.ToString());
         

            Teacher teacher = new Teacher("Jussi", "Konsoli", "Rektm8");
            teacher.Address = "getrektstreet m8";
            teacher.Age = 68;
            teacher.PhoneNumber = "1646543584";
            Console.WriteLine(teacher.ToString());


            Student student = new Student("Herra", "Opiskelija", "id45");
            student.Address = "koulukatujuttu";
            student.Age = 28;
            student.PhoneNumber = "34345476";
            Console.WriteLine(student.ToString());
            Console.WriteLine("press a key");
            Console.ReadLine();
        }
    }
}
