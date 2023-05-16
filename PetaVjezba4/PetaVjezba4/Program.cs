using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetaVjezba4
{
    class Program
    {
        /*Napisati program koji sadrži glavnu i dvije dodatne metode.
U prvoj dodatnoj metodi učitati n realnih(decimalnih) brojeva u složenu strukturu.
U drugoj dodatnoj metodi izračunati i ispisati aritmetičku sredinu unesenih brojeva.
Iz glavne metode pozvati dodatne metode.*/
        private static List <decimal> PrvaMetoda()
        {
            List<decimal> podaci = new List<decimal>();
            Console.WriteLine("Koliko realnih brojeva zelite unijeti: ");
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Unesite realni broj: ");
                podaci.Add(decimal.Parse(Console.ReadLine()));
            }
            return podaci;
        }

        private static void DrugaMetoda(List<decimal> podaci)
        {
            decimal zbroj = 0;
            for (int i=0; i<podaci.Count; i++)
            {
                zbroj += podaci[i];
            }
            Console.WriteLine("Aritmetička sredina iznosi: " + (decimal)zbroj / podaci.Count);
        }

        static void Main(string[] args)
        {
            List<decimal> podaci = PrvaMetoda();
            DrugaMetoda(podaci);
        }
    }
}
