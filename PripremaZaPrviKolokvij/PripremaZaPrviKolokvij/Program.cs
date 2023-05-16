using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaPrviKolokvij
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal broj;
            Console.Write("Unesite broj: ");
            decimal.TryParse(Console.ReadLine(), out broj);
            if (broj <= 0)
            {
                Console.WriteLine("Krivi unos.");
            }
            var x = broj - Math.Truncate(broj);
            Console.WriteLine("Decimalni dio broja je: "+x);
            Console.WriteLine("Cijeli dio broja je: "+Math.Truncate(broj));

        }
    }
}
