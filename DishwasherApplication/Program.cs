using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishwasherApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer washer = new Washer();
            washer.IsOn = true;
            washer.Time = 2;
            washer.Temperature = 70;
            washer.CleanClothes();
            Console.WriteLine("Time is " + washer.Time + " hours.");
            Console.WriteLine("Temperature is " + washer.Temperature + " degrees.");
        }
    }
}
