using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Motorcycle";
            vehicle.Speed = 97;
            vehicle.Tyres = 2;
            vehicle.PrintData();
            vehicle.ToString = vehicle.Name+ " " + vehicle.Speed+ " " + vehicle.Tyres;

            Console.WriteLine(vehicle.ToString);         
        }
    }
}
