using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad23
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            List<int> lista = new List<int>();
            while (true)
            {
                Console.Write("Unesite broj: ");
                int.TryParse(Console.ReadLine(), out broj);
                if(broj == 0)
                {
                    break;
                }
                else if(broj < 100 && broj >-100)
                {
                    lista.Add(broj);
                }
                else
                {
                    lista.Add(0);
                }
            }
            lista.ForEach(Console.WriteLine);
        }
    }
}
