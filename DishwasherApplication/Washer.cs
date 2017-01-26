using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishwasherApplication
{
    class Washer
    {
        public bool IsOn { get; set; }
        public double Time { get; set; }
        public int Temperature { get; set; }

        public void CleanClothes()
        {
            Console.WriteLine("Piip piip piip");
        }
    }
}
