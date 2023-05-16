using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad15
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj, brojac = 0;
            do
            {
                Console.WriteLine("Unesite broj: ");
                int.TryParse(Console.ReadLine(), out broj);
                if (broj < 10 && broj > -10)
                {
                    break;
                }
                else if (broj % 7 == 0)
                {
                    brojac++;
                }
            }
            while (true);
            Console.WriteLine("Ukupan broj djeljivih sa 7 je: " + brojac);
        }
    }
}
