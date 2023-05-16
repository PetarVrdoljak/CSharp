using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, broj;
            List<int> lista = new List<int>();
            Console.WriteLine("Odredite koliko brojeva želite u strukturi");
            int.TryParse(Console.ReadLine(), out n);
            while (true)
            {
                Console.WriteLine("Upisite cijeli broj: ");
                int.TryParse(Console.ReadLine(), out broj);
                if (lista.Count() == n) 
                {
                    break;
                }
                else
                {
                    lista.Add(broj);
                }
            }
            NajveciBroj(lista);
        }
        private static int NajveciBroj(List<int> lista)
        {
            var pom = 0;
            for(int i=0; i<lista.Count; i++)
            {
                if(lista[i] > pom)
                {
                    pom = lista[i];
                }
            }
            return pom;
        }
        private static int NajmanjiBroj(List<int> lista)
        {
            var x = 0;
            for(int i=0; i<lista.Count; i++)
            {
                if(lista[i] < x)
                {
                    x = lista[i];
                }
            }
            return x;
        }
        private static float AriSredina(List<int> lista)
        {
            int x = 0;
            for (int i =0;i < lista.Count; i++)
            {
                x += lista[i];
            }
            return (float)x / lista.Count;
        }
    }
}
