using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetaVjezbaMetode5
{
    class Program
    {
        private static decimal povKru(decimal r)
        {
            if (r <= 0)
            {
                return -1;
            }
            var polumjerSqr = r * r;
            var izracun = polumjerSqr * (decimal)Math.PI;
            return izracun;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite polumjer kružnice: ");
            var r = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Površina kruga iznosi " + povKru(r));
        }
    }
}
