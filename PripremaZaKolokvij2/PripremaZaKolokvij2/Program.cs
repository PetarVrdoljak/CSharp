using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaKolokvij2
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

            if(broj1 == broj2 && broj1 == broj3)
            {
                Console.WriteLine("Sva tri broja su jednaka.");
            }
            else if(broj1%2==0 && broj2%2!=0 && broj3 % 2 != 0)
            {
                Console.WriteLine("Suma brojeva je: {3}",broj1,broj2,broj3, broj1 + broj2 + broj3 );
            }
            else if(broj1<10 && broj2<10 && broj3<10)
            {
                Console.WriteLine("Produkt brojeva je: {3}", broj1, broj2, broj3, broj1 * broj2* broj3);
            }
            else
            {
                Console.WriteLine("Kraj.");
            }
        }
    }
}
