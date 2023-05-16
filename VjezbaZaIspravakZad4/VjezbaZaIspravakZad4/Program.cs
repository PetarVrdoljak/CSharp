using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad4
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

            if(broj1 <0 && broj2 <0 && broj3 <0)
            {
                Console.WriteLine("Svi brojevi su manji od nule.");
            }
            else if(broj1 == 0 && broj2 > 0 && broj3 > 0)
            {
                Console.WriteLine("Suma je: {2}", broj2, broj3, broj2 + broj3);
            }
            else if(broj1 >0 && broj2>0 && broj3 > 0)
            {
                Console.WriteLine("Produkt je: {3}", broj1, broj2, broj3, broj1 * broj2 * broj3);
            }
            else
            {
                Console.WriteLine("Kraj.");
            }
        }
    }
}
