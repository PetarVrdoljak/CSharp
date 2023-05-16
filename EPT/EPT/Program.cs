using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPT
{
    class Program
    {
        static void Main(string[] args)
        {
            string Opcija;

            Polaznik polaznik = new Polaznik();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Dobrodošli, odaberite opciju.");
                Console.WriteLine();
                Console.WriteLine("Opcija 1: Dodavanje novog polaznika.");
                Console.WriteLine("Opcija 2: Ažuriranje postojećeg polaznika.");
                Console.WriteLine("Opcija 3: Postavljenje datuma završetka tečaja (za određenog polaznika)");
                Console.WriteLine("Opcija 4: Postavljenje podatka o uspješnom završetku tečaja (za određenog polaznika)");
                Console.WriteLine("Opcija 5: Ispis svih polaznika");
                Console.WriteLine("Opcija 6: Ispis aktivnih polaznika (polaznici za koje tečaj još uvijek traje)");
                Console.WriteLine("Opcija 7: Ispis polaznika koji su odslušali tečaj, ali nisu uspješno položili");
                Console.WriteLine("Opcija 8: Ispis polaznika koji su odslušali tečaj i uspješno položili");
                Console.WriteLine("Opcija 9: Izlaz");
                Console.WriteLine("Utipkajte broj za određenu opciju.");
                Opcija = Console.ReadLine();
                Console.WriteLine();

                switch (Opcija)
                {
                    case "1":
                        polaznik.DodavanjeNovogPolaznika();
                        break;
                    case "2":
                        polaznik.AzuriranjePostojecegPolaznika();
                        break;
                    case "3":
                        polaznik.PostavljanjeDatumaZavrsetkaTecaja();
                        break;
                    case "4":
                        polaznik.PostavljanjePodatkaOUspjesnomZavrsetkuTecaja();
                        break;
                    case "5":
                        polaznik.IspisSvihPolaznika();
                        break;
                    case "6":
                        polaznik.IspisAktivnihPolaznika();
                        break;
                    case "7":
                        polaznik.IspisPolaznikaKojiSuOdslusaliTecajAliNisuJosPolozili();
                        break;
                    case "8":
                        polaznik.IspisPolaznikaKojiSuOdslusaliTecajIUspjesnoPolozili();
                        break;
                    case "9":
                        System.Environment.Exit(1);
                        break;
                }
            }
        }
    }
}
