using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Television television = new Television();
            television.IsOn = true;
            television.Channel = 3;
            television.Volume = 15;
            television.Source = "TV";
            television.ChangeChannel();
            Console.WriteLine("The channel is " + television.Channel);
            Console.WriteLine("The volume is " + television.Volume);
            Console.WriteLine("You're watching " + television.Source);
        }
    }
}
