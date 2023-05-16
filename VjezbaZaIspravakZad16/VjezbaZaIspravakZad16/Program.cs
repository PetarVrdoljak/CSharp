using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> podaci = new List<int>();
            int broj, broj4 = 0, broj2 = 0;
            while (true)
            {
                Console.WriteLine("Unesite broj: ");
                int.TryParse(Console.ReadLine(), out broj);
                if (broj == 0)
                {
                    break;
                }
                else if (broj < 100 && broj > 9)
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
