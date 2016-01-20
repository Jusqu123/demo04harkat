using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personApplication
{
    class Teacher : Person
    {
        public string Room { get; set; }

        public Teacher()
        {

        }
        public Teacher(string firstName, string Lastname, string room) 
            : base(firstName,Lastname)
        {
            Room = room;
        }
        public void TeacherMethod()
        {
            Console.WriteLine("Teacher does someething too . . .");
        }
        
        public override string ToString()
        {
            return base.ToString()+ "    "+ Room;
        }
    }
}

