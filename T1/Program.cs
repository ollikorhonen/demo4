using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 1;

            Console.WriteLine("Voit lopettaa painamalla 20");
            Console.Write("Anna kerros mihin haluat menna (1-5) : ");
            luku = int.Parse(Console.ReadLine());

            do
            {
                Elevator elevator = new Elevator();
                elevator.Floor = luku;
                Console.WriteLine("Hissi on kerroksessa: " + elevator.Floor);

                Console.WriteLine("\nVoit lopettaa painamalla 20");
                Console.Write("Anna kerros mihin haluat menna (1-5) : ");
                luku = int.Parse(Console.ReadLine());

            } while (luku != 20);
        }
    }
}
