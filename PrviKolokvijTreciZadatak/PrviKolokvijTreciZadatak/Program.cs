using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviKolokvijTreciZadatak
{
    class Program
    {
        /*Napišite program koji se sastoji od glavne i tri dodatne metode.
        U prvoj dodatnoj metodi učitati 10 cijelih brojeva i pohraniti ih u složenu strukutru podataka.
        U drugoj dodatnoj metodi zamijeniti sve negativne brojeve u složenoj strukturi podataka 
        sa njihovom apsolutnom vrijednošću.
        Treća dodatna metoda služi za ispis sadržaja složene strukture podataka.
        Dodatne metode se pozivaju iz glavne metode.*/
        static void Main(List<int> podaci)
        {
            var prvi = prvaMetoda(podaci);
        }
        private static int prvaMetoda(string[] args)
        {
            List<int> podaci = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Unesite cijeli broj: ");
                podaci.Add(int.Parse(Console.ReadLine()));
            }
            return (podaci.ForEach(Console.WriteLine));
        }
        private static int Drugametoda(List<int> podaci)
        {
            if 
        }
        private static void Trecametoda(int prvi, int drugi)
        {
            Console.WriteLine(prvi);
            Console.WriteLine(drugi);
        }
    }
}
