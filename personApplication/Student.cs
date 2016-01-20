using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personApplication
{
    class Student : Person
    {
        public string StudentID { get; set; }


        public Student()
        {

        }
        public Student(string firstName, string Lastname, string studentID)
            : base(firstName, Lastname)
        {
            StudentID = studentID;
        }
        public void StudentMethod()
        {
            Console.WriteLine("student does also something too . . .");
        }

        public override string ToString()
        {
            return base.ToString() + "    " + StudentID;
        }
    }
}
