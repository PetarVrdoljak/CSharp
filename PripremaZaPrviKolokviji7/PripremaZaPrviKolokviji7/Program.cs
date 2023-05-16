using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaPrviKolokviji7
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj,lijevaz=0,desnaz=0;
            Console.WriteLine("Unesite broj: ");
            int.TryParse(Console.ReadLine(), out broj);
            if(broj>9 && broj < 100)
            {
                lijevaz = broj / 10;
                desnaz = broj % 10;
                if (lijevaz % desnaz== 0)
                {
                    Console.WriteLine(lijevaz + " je djeljivo s " + desnaz);
                }
                else
                {
                    Console.WriteLine(lijevaz + " nije djeljivo s " + desnaz);
                }
            }
            else
            {
                Console.WriteLine("Krivi unos.");
            }
        }
    }
}
