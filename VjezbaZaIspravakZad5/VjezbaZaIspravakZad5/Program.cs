using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspravakZad5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stanovniciSela = new List<string>();
            stanovniciSela.Add("Ana Anic");
            stanovniciSela.Add("Marko Markic");
            stanovniciSela.Add("Iva Ivic");
            stanovniciSela.Add("Tomo Tomic");
            for (int i = 0; i<stanovniciSela.Count; i++)
            {
                string ime;
                Console.WriteLine("Unesite ime stanovnika koji se iselio: ");
                ime = Console.ReadLine();
                stanovniciSela.Remove(ime);
                if (ime == "Ana Anic" || ime == "Marko Markic" || ime == "Iva Ivic" || ime == "Tomo Tomic")
                {
                    stanovniciSela.Remove(ime);
                }
                else if (ime == "kraj")
                {
                    stanovniciSela.Sort();
                    Console.WriteLine(" ");
                    Console.WriteLine("U selu je ostalo " + stanovniciSela.Count + " stanovnika. Oni su: ");
                    foreach (string x in stanovniciSela)
                        Console.WriteLine(x);
                    break;
                }
                else
                {
                    Console.WriteLine("Ne postoji stanovnik sa unesenim imenom.");
                }
            }
        }
    }
}
