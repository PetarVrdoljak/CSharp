using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad18
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj, brojac = 0;
            while (true)
            {
                Console.Write("Unesite broj: ");
                int.TryParse(Console.ReadLine(), out broj);
                if (broj <10 && broj > - 10)
                {
                    break;
                }
                else if(broj % 7== 0)
                {
                    brojac++;
                }
            }
            Console.WriteLine("Broj brojeva djeljivih sa 7 je: " + brojac);
        }
    }
}
