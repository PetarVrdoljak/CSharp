using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetaVjezba1
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;

            Console.Write("Unesite jedan cijeli pozitivan broj: ");
            int.TryParse(Console.ReadLine(), out broj);

            if(broj > 0)
            {
                ObrnutiRedosljed(broj);
                Console.WriteLine("\n{0}", broj);
            }
            else
            {
                Console.WriteLine("Pogrešan unos ! ! !");
            }

            Console.ReadKey();
        }

        private static void ObrnutiRedosljed(int x)
        {
            while (x > 0)
            {
                Console.Write("{0}", x % 10);
                x /= 10; // x = x /10;
            }
        }

    }
}
