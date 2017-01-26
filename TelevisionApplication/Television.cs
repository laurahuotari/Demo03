using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionApplication
{
    class Television
    {
        public bool IsOn { get; set; }
        public int Channel { get; set; }
        public int Volume { get; set; }
        public string Source { get; set; }

        public void ChangeChannel()
        {
            Console.WriteLine("Change channel: ");
        }
    }
}
