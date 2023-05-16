using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = metoda1();
            metoda2(lista);
            metoda3(lista);
        }
        private static List<int> metoda1()
        {
            int broj;
            List<int> lista = new List<int>();
            while (true)
            {
                Console.Write("Unesite broj: ");
                int.TryParse(Console.ReadLine(), out broj);
                if (lista.Count() == 10)
                {
                    break;
                }
                else
                {
                    lista.Add(broj);
                }
            }
            return lista;
        }
        private static List<int> metoda2(List<int> lista)
        {
            int i;
            for(i = 0; i < lista.Count(); i++)
            {
                if (lista[i] < 0)
                {
                    lista[i] = lista[i] * (-1);
                }
            }
            return lista;
        }
        private static void metoda3(List<int> lista)
        {
            foreach (int x in lista)
            {
                Console.WriteLine("{0}", x);
            }
        }
    }
}
