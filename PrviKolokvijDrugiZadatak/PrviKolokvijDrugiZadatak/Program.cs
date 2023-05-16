using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviKolokvijDrugiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Napišite program koji dozvoljava unos cjelobrojnih elemenata složene strukture podataka dok korisnik ne unese nulu(nula se ne pohranjuje u strukturu).
            Nakon zavšetka učitavanja brojeva sve četveroznamenkaste brojeve pretvoriti u troznamenkaste, a sve dvoznamenkaste u jednoznamenkaste na način da ih se podijeli sa 10.
            Ispisati sadržaj složene strukture podataka nakon svih izmjena.*/
            List<int> podaci = new List<int>();
            int broj, broj4=0,broj3=0,broj2=0;
            while (true)
            {
                Console.WriteLine("Unesite broj: ");
                int.TryParse(Console.ReadLine(), out broj);
                if (broj == 0)
                {
                    break;
                }
                else if(broj <1000 && broj > 99)
                {
                    broj3 = broj / 10;
                    podaci.Add(broj3);    
                }
                else if(broj <100 && broj > 9)
                {
                    broj2 = broj / 10;
                    podaci.Add(broj2);
                }
                else if (broj < 10000 && broj > 999)
                {
                    broj4 = broj / 10;
                    podaci.Add(broj4);
                }
                else
                {
                    podaci.Add(broj);
                }
            }
            podaci.ForEach(Console.WriteLine);
        }
    }
}
