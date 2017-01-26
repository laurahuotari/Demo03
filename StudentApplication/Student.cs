using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    class Student
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Address { get; set; }
        public string TrainingProgram { get; set; }
        public string StudentNumber { get; set; }
        public string StudiesPerDay { get; set; }

        public void TravelsToSchool()
        {
            
        }
        public void WayToSchool()
        {

        }

        public void PrintData()
        {
            Console.WriteLine("Studet: ");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Birth year: " + BirthYear);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Training program: " + TrainingProgram);
            Console.WriteLine("Student number: " + StudentNumber);
            Console.WriteLine("");
        }
    }
}
