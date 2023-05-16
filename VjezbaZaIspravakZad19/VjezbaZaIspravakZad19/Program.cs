using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad19
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj, broj4 = 0, broj2 = 0;
            List<int> lista = new List<int>();
            while (true)
            {
                Console.Write("Upisšite broj: ");
                int.TryParse(Console.ReadLine(),out broj);
                if(broj == 0)
                {
                    break;
                }
                else if(broj <10000 && broj > 999)
                {
                    broj4 = broj / 10;
                    lista.Add(broj4);
                }
                else if(broj <100 && broj >9)
                {
                    broj2 = broj / 10;
                    lista.Add(broj2);
                }
                else
                {
                    lista.Add(broj);
                }
            }
            lista.ForEach(Console.WriteLine);
        }
    }
}
