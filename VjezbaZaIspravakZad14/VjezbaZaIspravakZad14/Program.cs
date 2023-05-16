using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad14
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
                if (broj == 0)
                {
                    break;
                }
                else if(broj < 0)
                {
                    Console.WriteLine("Krivi unos.");
                }
                else
                {
                    lista.Add(broj);
                }
            }
            Console.WriteLine();
            prvametoda(lista);
            drugametoda(lista);
        }
        private static void prvametoda(List<int> lista)
        {
            int i;
            foreach(int x in lista)
            {
                Console.WriteLine("{0}", x);
            }
        }
        private static void drugametoda(List<int> lista)
        {
            int i, r = 1;
            for (i=0; i<lista.Count; i++)
            {
                r *=lista[i];
            }
            Console.WriteLine("Produkt brojeva je: " + r);
        }
    }
}
