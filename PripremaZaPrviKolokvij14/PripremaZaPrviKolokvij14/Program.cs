using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaPrviKolokvij14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista1 = new List<int>();
            int broj;
            while (true)
            {
                Console.Write("Unesite broj: ");
                int.TryParse(Console.ReadLine(), out broj);
                if (broj == 0)
                {
                    break;
                }
                else if (broj < 0)
                {
                    Console.WriteLine("Krivi unos.");
                }

                else
                {
                    lista1.Add(broj);
                }
                Console.ReadKey();
            }
            Console.WriteLine();
            metoda1(lista1);
            Console.Write("Umnozak brojeva je: {0}", metoda2(lista1));
            Console.ReadKey();
        }
        private static void metoda1(List<int> lista1)
        {
            foreach (int x in lista1)
            {
                Console.WriteLine("{0}", x);
            }
        }
        private static int metoda2(List<int> lista1)
        {
            int umnozak = 1, i;
            for (i = 0; i < lista1.Count(); i++)
            {
                umnozak *= lista1[i];
            }
            return umnozak;
        }
    }
}