using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> podaci = new List<int>();
            int broj;
            while (true)
            {
                Console.WriteLine("Unesite broj: ");
                int.TryParse(Console.ReadLine(), out broj);
                if (broj % 10 != 0)
                {
                    Console.WriteLine("Krivi unos.");
                }
                else if(broj == 0)
                {
                    break;
                }
                podaci.Add(broj);
            }
            podaci.Sort();
            podaci.ForEach(Console.WriteLine);
            Console.WriteLine(string.Format(string.Join(",", podaci)));
        }
    }
}
