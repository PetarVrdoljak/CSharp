using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetaVjezba3
{
    class Program
    {
        private static int Prvametoda(List<int> podaci)
        {
            int brojac = 0;
            for (int i = 0; i < podaci.Count; i++)
            {
                if (podaci[i] > 9 && podaci[i] < 100)
                {
                    brojac++;
                }

                else if (podaci[i] > 99 && podaci[i] < 1000)
                {
                    brojac++;
                }
            }
            return brojac;
        }
        private static int Drugametoda(List<int> podaci)
        {
            int brojac = 0;
            for (int i = 0; i < podaci.Count; i++)
            {
                List<int> list = new List<int>();
                while (podaci[i] > 0)
                {
                    list.Add(podaci[i] % 10);
                    podaci[i] = podaci[i] / 10;
                }
                if (list[0] == 7)
                {
                    brojac++;
                }
            }
            return brojac;
        }
        private static void Trecametoda(int prvi, int drugi)
        {
            Console.WriteLine("Ukupni broj dvoznamenkastih i troznamenkastih brojeva iznosi: " + prvi);
            Console.WriteLine("Ukpuni broj brojeva koji posljednju znamenku imaju broj 7: " + drugi);
        }
            static void Main(string[] args)
        {
            List<int> podaci = new List<int>();
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Unesite cijeli broj: ");
                podaci.Add(int.Parse(Console.ReadLine()));
            }
            var prvi = Prvametoda(podaci);
            var drugi = Drugametoda(podaci);
            Trecametoda(prvi, drugi);
        }
    }
}
