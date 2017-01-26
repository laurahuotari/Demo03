using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas();
            kiuas.IsOn = true;
            kiuas.Temperature = 80;
            kiuas.Humidity = 90.0;
            kiuas.ThrowWater();
            Console.WriteLine("Temperature is " + kiuas.Temperature);
            Console.WriteLine("Humidity is " + kiuas.Humidity);
        }
    }
}
