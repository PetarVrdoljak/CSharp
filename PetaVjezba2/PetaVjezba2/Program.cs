using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetaVjezba2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            Console.WriteLine("Koliko cijelih brojeva zelite unijeti: ");

            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)

            {

                Console.WriteLine("Unesite cijeli broj: ");

                lista.Add(int.Parse(Console.ReadLine()));

            }
            var najveci = najveciBroj(lista);

            var najmanji = najmanjiBroj(lista);

            var arSredina = aritmetickaSredina(lista);



            Console.WriteLine("Najveci broj je: " + najveci);

            Console.WriteLine("Najmanji broj je: " + najmanji);

            Console.WriteLine("Aritmeticka sredina iznosi: " + arSredina);
        }
        private static int najveciBroj(List<int> lista)
        {
            var pom = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > pom)
                {
                    pom = lista[i];
                }
            }
            return pom;
        }
        private static int najmanjiBroj(List<int> lista)
        {
            var pom = lista[0];
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] < pom)
                {
                    pom = lista[i];
                }
            }
            return pom;
        }
        private static float aritmetickaSredina(List<int> lista)
        {
            var zbroj = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                zbroj += lista[i];
            }
            return (float)zbroj / lista.Count;
        }
    }
}
