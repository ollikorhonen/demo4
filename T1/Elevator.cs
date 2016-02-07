using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Elevator
    {
        private readonly int maxFloor = 5;
        private readonly int minFloor = 1;

        private int floor;

        public int Floor
        {

            get
            {
                return floor;
            }
            set
            {
                if (value < minFloor)
                {
                    Console.WriteLine("Semmoista kerrosta ei ole olemassa");
                    floor = 1;
                }
                else if (value > maxFloor)
                {
                    Console.WriteLine("Semmosta kerrosta ei ole olemassa");
                    floor = 5;
                }
                else
                {
                    floor = value;
                }
            }
        }



    }
}
