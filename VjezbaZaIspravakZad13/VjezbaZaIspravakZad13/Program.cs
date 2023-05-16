using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ucitavanje_brojeva = metoda1();
            metoda2(ucitavanje_brojeva);
            Console.ReadKey();
        }
        private static List<int> metoda1()
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
                else if (broj < 1 || broj > 100)
                {
                    Console.WriteLine("Krivi unos.");
                }
                else
                {
                    lista1.Add(broj);
                }
            }
            return lista1;
        }

        private static void metoda2(List<int> lista1)
        {
            int i;
            for (i = 0; i < lista1.Count(); i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}", lista1[i]);
                }
            }
        }
    }
}
