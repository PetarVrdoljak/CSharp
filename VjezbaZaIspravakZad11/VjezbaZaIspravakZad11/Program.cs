using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> podaci = new List<int>();
            int broj;
            double r = 1.0;
            while (true)
            {
                Console.Write("Unesite broj: ");
                int.TryParse(Console.ReadLine(), out broj);

                if (broj == 0)
                {
                    break;
                }
                else if (broj < 0)
                {
                    Console.WriteLine("Krivi unos.");
                }
                podaci.Add(broj);
            }
                Console.WriteLine();
                podaci.ForEach(Console.WriteLine);
                for(int i=0; i< podaci.Count; i++)
                {
                    r = r * podaci[i];
                }
                Console.WriteLine("Produkt brojeva je: " + r);
        }
    }
}
