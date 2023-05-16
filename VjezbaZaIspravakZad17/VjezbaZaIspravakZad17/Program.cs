using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad17
{
    class Program
    {
        static void Main(string[] args)

        {

            List<int> lista = metoda1();

            metoda2(lista);

            metoda3(lista);

            Console.ReadKey();



        }

        private static List<int> metoda1()

        {

            int broj;

            List<int> lista1 = new List<int>();

            while (true)

            {

                Console.Write("Unesite broj: ");

                int.TryParse(Console.ReadLine(), out broj);

                if (lista1.Count() == 10)

                {

                    break;

                }

                else

                {

                    lista1.Add(broj);

                }

            }

            return lista1;

        }



        private static List<int> metoda2(List<int> lista1)

        {

            int i;

            for (i = 0; i < lista1.Count(); i++)

            {

                if (lista1[i] < 0)

                {

                    lista1[i] = lista1[i] * (-1);

                }

            }

            return lista1;

        }

        private static void metoda3(List<int> lista1)

        {

            foreach (int x in lista1)

            {

                Console.WriteLine("{0}", x);

            }

        }
    }
}
