using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.WriteLine("Lopeta painamalla 01");
            Console.Write("Anna voimakkuus kokonaislukuna (1-100) : ");
            luku = int.Parse(Console.ReadLine());

            do
            {
                Vahvistin vahvistin = new Vahvistin();
                vahvistin.Volume = luku;
                Console.WriteLine("Voimakkuus on " + vahvistin.Volume);

                Console.WriteLine("\nLopeta painamalla 01");
                Console.Write("Anna voimakkuus kokonaislukuna (1-100) : ");
                luku = int.Parse(Console.ReadLine());
            } while (luku != 01);
        }
    }
}
