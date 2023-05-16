using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPT
{
    class Polaznik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }
        public DateTime Datum_pocetka_tecaja { get; set; }
        public DateTime Datum_zavrsetka_tecaja { get; set; }
        public string Uspjesno_polozen_tecaj { get; set; }
        public List<Polaznik> ListaPolaznika { get; set; }

        public Polaznik()
        {
            this.Ime = string.Empty;
            this.Prezime = string.Empty;
            this.OIB = string.Empty;
            this.Datum_pocetka_tecaja = DateTime.MinValue;
            this.Datum_zavrsetka_tecaja = DateTime.MinValue;
            this.Uspjesno_polozen_tecaj = string.Empty;
            this.ListaPolaznika = new List<Polaznik>();
        }
        public Polaznik(string ime, string prezime, string oib, DateTime datum_pocetka_tecaja)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.OIB = oib;
            this.Datum_pocetka_tecaja = datum_pocetka_tecaja;
            this.Datum_zavrsetka_tecaja = DateTime.MinValue;
            this.Uspjesno_polozen_tecaj = "Nije polozen";

        }

        public void DodavanjeNovogPolaznika() /*1*/
        {            
            DateTime datum_pocetka_tecaja;
            Console.WriteLine();
            Console.Write("Unesite ime polaznika: ");
            string ime = Console.ReadLine();
            Console.Write("Unesite prezime polaznika: ");
            string prezime = Console.ReadLine();
            Console.Write("Unesite OIB polaznika: ");
            string oib = Console.ReadLine();
            try
            {
                Console.WriteLine("Unesite datum početka tečaja polaznika: yyyy/mm/dd");
                datum_pocetka_tecaja = DateTime.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Pogrešan unos!");
                return;
            }

            Polaznik polaznik = new Polaznik(ime, prezime, oib, datum_pocetka_tecaja);
            if (!ime.Equals("") && !prezime.Equals("") && !oib.Equals(""))
            {
                ListaPolaznika.Add(polaznik);
            }
            else
            {
                Console.WriteLine("Polaznik ne smije imati prazne podatke.");
            }
        }

        public void AzuriranjePostojecegPolaznika() /*2*/
        {
            if (ListaPolaznika.Any())
            {
                IspisSvihPolaznika();
                int broj;
                Console.WriteLine("S rednim brojem odaberite polaznika kojem želite ažurirati podatke: ");
                int.TryParse(Console.ReadLine(), out broj);
                broj--;

                if (ListaPolaznika.Count() > broj && broj >= 0)
                {
                    DateTime datum_pocetka_tecaja;

                    Console.Write("Unesite ime polaznika: ");
                    string ime = Console.ReadLine();
                    if (ime.Equals("")) ime = ListaPolaznika[broj].Ime;
                    Console.Write("Unesite prezime polaznika: ");
                    string prezime = Console.ReadLine();
                    if (prezime.Equals("")) prezime = ListaPolaznika[broj].Prezime;
                    Console.Write("Unesite OIB polaznika: ");
                    string oib = Console.ReadLine();
                    if (oib.Equals("")) oib = ListaPolaznika[broj].OIB;
                    try
                    {
                        Console.Write("Unesite datum početka tečaja polaznika: yyyy/mm/dd");
                        DateTime.TryParse(Console.ReadLine(), out datum_pocetka_tecaja);
                        datum_pocetka_tecaja = ListaPolaznika[broj].Datum_pocetka_tecaja;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Pogrešan unos!");
                        return;
                    }


                    ListaPolaznika[broj].Ime = ime;
                    ListaPolaznika[broj].Prezime = prezime;
                    ListaPolaznika[broj].OIB = oib;
                    ListaPolaznika[broj].Datum_pocetka_tecaja = datum_pocetka_tecaja;
                }
                else
                {
                    Console.WriteLine("Trenutno nema polaznika s tim rednim brojem.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Trenutno nema polaznika.");
            }
        }

        public void PostavljanjeDatumaZavrsetkaTecaja() /*3*/
        {
            if (ListaPolaznika.Any())
            {
                int broj;
                DateTime datum_zavrsetka;
                IspisSvihPolaznika();
                Console.WriteLine("S rednim brojem odaberite polaznika kojem želite postaviti datum završetka tečaja: ");
                int.TryParse(Console.ReadLine(), out broj);
                broj--;
                if (ListaPolaznika.Count() > broj && broj >= 0)
                {
                    try
                    {
                        Console.WriteLine("Unesite datum završetka tečaja: ");
                        datum_zavrsetka = DateTime.Parse(Console.ReadLine());
                        if (datum_zavrsetka < ListaPolaznika[broj].Datum_pocetka_tecaja)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Pogrešan unos.");
                        }
                        Console.WriteLine();
                        ListaPolaznika[broj].Datum_zavrsetka_tecaja = datum_zavrsetka;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Pogrešan unos.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Trenutno nema polaznika s tim rednim brojem.");
                }
            }
            else
            {
                Console.WriteLine("Trenutno nema polaznika.");
            }
        }

        public void PostavljanjePodatkaOUspjesnomZavrsetkuTecaja() /*4*/
        {
            if (ListaPolaznika.Any())
            {
                int broj;
                IspisSvihPolaznika();
                Console.WriteLine("S rednim brojem odaberite polaznika kojem želite postaviti status završetka tečaja: ");
                int.TryParse(Console.ReadLine(), out broj);
                broj--;

                if (ListaPolaznika.Count() > broj && broj >= 0)
                {
                    Console.WriteLine("Unesite da li je polaznik položio tečaj: Polozen - Nije polozen");
                    string pol = Console.ReadLine();
                    if (pol.Equals("Polozen"))
                    {
                        if (ListaPolaznika[broj].Datum_zavrsetka_tecaja < DateTime.Today && !ListaPolaznika[broj].Datum_zavrsetka_tecaja.Equals(DateTime.MinValue))
                        {
                            ListaPolaznika[broj].Uspjesno_polozen_tecaj = "Polozen";
                        }
                        else
                        {
                            Console.WriteLine("Tečaj nije završen za polaznika!");
                        }
                    }
                    else
                    {
                        ListaPolaznika[broj].Uspjesno_polozen_tecaj = "Nije polozen";
                    }
                }
                else
                {
                    Console.WriteLine("Trenutno nema polaznika s tim rednim brojem.");
                }
            }
            else
            {
                Console.WriteLine("Trenutno nema polaznika.");
            }
        }

        public void IspisSvihPolaznika() /*5*/
        {
            if (ListaPolaznika.Any())
            {
                foreach (Polaznik polaznik in ListaPolaznika)
                {
                    Console.WriteLine("Ime polaznika: {0}", polaznik.Ime);
                    Console.WriteLine("Prezime polaznika: {0}", polaznik.Prezime);
                    Console.WriteLine("OIB polaznika: {0}", polaznik.OIB);
                    Console.WriteLine("Datum početka tečaja polaznika: {0}", polaznik.Datum_pocetka_tecaja);
                    Console.WriteLine("Datum završetka tečaja polaznika: {0}", polaznik.Datum_zavrsetka_tecaja);
                    Console.WriteLine("Uspješno položen tečaj: {0}", polaznik.Uspjesno_polozen_tecaj);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Trenutno nema polaznika.");
            }
        }

        public void IspisAktivnihPolaznika() /*6*/
        {
            if (ListaPolaznika.Any())
            {
                foreach (Polaznik polaznik in ListaPolaznika)
                {
                    if (polaznik.Datum_zavrsetka_tecaja > DateTime.Today || polaznik.Datum_zavrsetka_tecaja.Equals(DateTime.MinValue))
                    {
                        Console.WriteLine("Ime polaznika: {0}", polaznik.Ime);
                        Console.WriteLine("Prezime polaznika: {0}", polaznik.Prezime);
                        Console.WriteLine("OIB polaznika: {0}", polaznik.OIB);
                        Console.WriteLine("Datum početka tečaja polaznika: {0}", polaznik.Datum_pocetka_tecaja);
                        Console.WriteLine("Datum završetka tečaja polaznika: {0}", polaznik.Datum_zavrsetka_tecaja);
                        Console.WriteLine("Uspješno položen tečaj: {0}", polaznik.Uspjesno_polozen_tecaj);
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Trenutno nema polaznika.");
            }
        }

        public void IspisPolaznikaKojiSuOdslusaliTecajAliNisuJosPolozili() /*7*/
        {
            if (ListaPolaznika.Any())
            {
                foreach (Polaznik polaznik in ListaPolaznika)
                {
                    if ((!polaznik.Datum_zavrsetka_tecaja.Equals(DateTime.MinValue) && polaznik.Datum_zavrsetka_tecaja < DateTime.Today) && polaznik.Uspjesno_polozen_tecaj.Equals("Nije polozen"))
                    {
                        Console.WriteLine("Ime polaznika: {0}", polaznik.Ime);
                        Console.WriteLine("Prezime polaznika: {0}", polaznik.Prezime);
                        Console.WriteLine("OIB polaznika: {0}", polaznik.OIB);
                        Console.WriteLine("Datum početka tečaja polaznika: {0}", polaznik.Datum_pocetka_tecaja);
                        Console.WriteLine("Datum završetka tečaja polaznika: {0}", polaznik.Datum_zavrsetka_tecaja);
                        Console.WriteLine("Uspješno položen tečaj: {0}", polaznik.Uspjesno_polozen_tecaj);
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Trenutno nema polaznika.");
            }
        }

        public void IspisPolaznikaKojiSuOdslusaliTecajIUspjesnoPolozili() /*8*/
        {
            if (ListaPolaznika.Any())
            {
                foreach (Polaznik polaznik in ListaPolaznika)
                {
                    if ((!polaznik.Datum_zavrsetka_tecaja.Equals(DateTime.MinValue) && polaznik.Datum_zavrsetka_tecaja < DateTime.Today) && polaznik.Uspjesno_polozen_tecaj.Equals("Polozen"))
                    {
                        Console.WriteLine("Ime polaznika: {0}", polaznik.Ime);
                        Console.WriteLine("Prezime polaznika: {0}", polaznik.Prezime);
                        Console.WriteLine("OIB polaznika: {0}", polaznik.OIB);
                        Console.WriteLine("Datum početka tečaja polaznika: {0}", polaznik.Datum_pocetka_tecaja);
                        Console.WriteLine("Datum završetka tečaja polaznika: {0}", polaznik.Datum_zavrsetka_tecaja);
                        Console.WriteLine("Uspješno položen tečaj: {0}", polaznik.Uspjesno_polozen_tecaj);
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Trenutno nema polaznika.");
            }
        }
    }
}

