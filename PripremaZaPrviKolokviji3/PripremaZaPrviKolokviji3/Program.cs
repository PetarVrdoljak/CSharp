using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaPrviKolokviji3
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj1, broj2, broj3;
            Console.WriteLine("Unesite prvi broj: ");
            int.TryParse(Console.ReadLine(), out broj1);
            Console.WriteLine("Unesite drugi broj: ");
            int.TryParse(Console.ReadLine(), out broj2);
            Console.WriteLine("Unesite treći broj: ");
            int.TryParse(Console.ReadLine(), out broj3);

            if (broj1 % 2 == 0 && broj2 % 2 == 0 && broj3 % 2 == 0)
            {
                Console.WriteLine("Sva tri broja su parna.");
            }
            else if (broj1 > 0 && broj2 > 0 && broj3 == 12)
            {
                Console.WriteLine("Produkt brojeva je: {3}", broj1, broj2, broj3, broj1 * broj2 * broj3);
            }
            else if (broj1  == 1 && broj2 == 1 && broj3 ==1)
            {
                Console.WriteLine("Svi brojevi su jednaki broju jedan. ");
            }
            else
            {
                Console.WriteLine("Kraj.");
            }
        }
    }
}
