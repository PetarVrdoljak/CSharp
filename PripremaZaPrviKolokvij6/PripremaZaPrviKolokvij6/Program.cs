using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaPrviKolokvij6
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj, sum = 0, t, r;
            Console.WriteLine("Unesite broj: ");
            broj = int.Parse(Console.ReadLine());
            if (broj > 99 && broj <1000)
            {
                for (t = broj; t != 0; t = t / 10)
                {
                    r = t % 10;
                    sum = sum * 10 + r;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Krivi unos. ");
            }
        }
    }
}
