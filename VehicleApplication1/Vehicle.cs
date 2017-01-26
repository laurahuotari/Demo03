using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication1
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }
        public string ToString { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Vehicle properties: ");
            Console.WriteLine("- name: " + Name);
            Console.WriteLine("- speed: " + Speed);
            Console.WriteLine("- tyres: " + Tyres);
        }

        




    }
}
