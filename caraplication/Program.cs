using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caraplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one car object 
            car car = new car();
            car.Speed = 100;
            car.Height = 0;
            Console.WriteLine("Speed is {0} km/h\nHeight is {1} m", car.Speed, car.Height);
            Console.ReadLine();


        }
    }
}
