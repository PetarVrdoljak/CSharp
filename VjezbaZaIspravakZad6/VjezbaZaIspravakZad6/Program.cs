using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad6
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj, reverse=0, rem;
            Console.Write("Unesite broj: ");
            int.TryParse(Console.ReadLine(), out broj);
            if(broj <99 || broj >1000)
            {
                Console.WriteLine("Krivi unos.");
            }
            else
            {
                while (broj != 0)
                {
                    rem = broj % 10;
                    reverse = reverse * 10 + rem;
                    broj /= 10;
                }

                Console.WriteLine("Reversed Number: " + reverse);
            }
        }
    }
}
