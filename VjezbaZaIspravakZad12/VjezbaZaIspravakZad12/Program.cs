using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float a, b, h;
                Console.Write("Unesite vrijednost a: ");
                a = float.Parse(Console.ReadLine());
                Console.Write("Unesite vrijednost b: ");
                b = float.Parse(Console.ReadLine());
                Console.Write("Unesite vrijednost h: ");
                h = float.Parse(Console.ReadLine());
                if (a <= 0 || b <=0 || h <= 0)
                {
                    Console.WriteLine("Krivi unos podataka.");
                }
                else
                {
                    Console.WriteLine("Povrsina trapeza iznosi: {0}", povrsina(a, b, h));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Krivi unos podataka.");
            }
            catch (Exception)
            {
                Console.WriteLine("Doslo je do pogreske.");
            }
            Console.ReadKey();
        }
        private static float povrsina(float x, float y, float z)
        {
            float P;
            P = ((float)1 / 2) * (x + y) * z;
            return P;
        }
    }
}
