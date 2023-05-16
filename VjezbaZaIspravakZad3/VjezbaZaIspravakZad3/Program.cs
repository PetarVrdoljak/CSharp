using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj1, broj2, broj3;
            Console.WriteLine("Unesite broj 1: ");
            int.TryParse(Console.ReadLine(), out broj1);
            Console.WriteLine("Unesite broj 2: ");
            int.TryParse(Console.ReadLine(), out broj2);
            Console.WriteLine("Unesite broj 3: ");
            int.TryParse(Console.ReadLine(), out broj3);

            if(broj1 % 2 == 0 && broj2 % 2 == 0 && broj3 % 2 == 0)
            {
                Console.WriteLine("Sva tri broja su parna.");
            }
            else if(broj3 == 12 && broj1 >=0 && broj2 >=0)
            {
                Console.WriteLine("Produkt brojeva je: {3}", broj1, broj2, broj3, broj1 * broj2 * broj3);
            }
            else if(broj1 == 1 && broj2 == 1 && broj3 == 1)
            {
                Console.WriteLine("Svi su brojevi jednaki broju jedan.");
            }
            else
            {
                Console.WriteLine("Kraj.");
            }
        }
    }
}
