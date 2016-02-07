using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Vahvistin
    {
        private int maxVolume = 100;
        private int minVolume = 0;

        private int volume;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < minVolume)
                {
                    Console.WriteLine("Et voi antaa noin pienta voimakkuutta");
                    volume = 0;
                }
                else if (value > maxVolume)
                {
                    Console.WriteLine("Et voi antaa noin isoa voimakkuutta");
                    volume = 100;
                }
                else
                {
                    volume = value;
                }

            }
        }
    }
}
