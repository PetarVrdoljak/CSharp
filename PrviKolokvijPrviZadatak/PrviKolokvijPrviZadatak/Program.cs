using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviKolokvijPrviZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Napišite program koji učitava sa tipkovnice cijele brojeve dokle god se ne unese jednoznamenkasti broj.
            Nakon završetka učitavanja brojeva ispisati koliko je učitano brojeva djeljivih sa 7
            .U proračun ne ulazi zadnje učitani jednoznamenkasti broj.*/
            int broj,brojac=0;
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
            Console.WriteLine("Ukupan broj djeljivih sa 7 je: "+brojac);
        }
    }
}
