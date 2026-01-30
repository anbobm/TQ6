using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothek
{
    internal class Bibliothek
    {
        string name;
        string stadt;
        public List<Buch> buecher;
        List<Kunde> kunden;
        List<Ausleihe> ausleihen;

        //Konstruktor
        public Bibliothek(string name, string stadt)
        {
            this.name = name;
            this.stadt = stadt;
            buecher = new List<Buch>();
            kunden = new List<Kunde>();
            ausleihen = new List<Ausleihe>();
        }

        public void BuecherHinzufuegen(Buch buch)
        {
            buecher.Add(buch);
        }

        public List<Buch> Buecher => buecher;

        private int naechsteKundennummer = 0;
        public Kunde KundeErstellen(string name, string adresse)
        {
            string kundennummer = naechsteKundennummer.ToString("D7");
            naechsteKundennummer++;

            Kunde kunde = new Kunde(kundennummer, name, adresse);
            kunden.Add(kunde);
            return kunde;
        }
        public Kunde Login(string kundennummer)
        {
            foreach (Kunde k in kunden)
            {
                if (k.kundennummer == kundennummer)
                {
                    return k;
                }
            }
            return null;
        }
        public bool Ausleihverfahren(string isbn, Kunde kunde)
        {
            Buch gefundenesBuch = null;

            foreach (Buch b in buecher)
            {
                if (b.isbn == isbn)
                {
                    gefundenesBuch = b;
                    break;
                }
            }

            if (gefundenesBuch == null)
            {
                Console.WriteLine("Buch nicht gefunden.");
                return false;
            }

            foreach (Ausleihe a in ausleihen)
            {
                if (a.buch == gefundenesBuch && a.rueckgabedatum == null)
                {
                    Console.WriteLine("Buch ist bereits ausgeliehen.");
                    return false;
                }
            }

            ausleihen.Add(new Ausleihe(gefundenesBuch, kunde));
            return true;
        }
        public bool Zurueckgeben(string isbn, Kunde kunde)
        {
            foreach (Ausleihe a in ausleihen)
            {
                if (a.buch.isbn == isbn && a.kunde == kunde && a.rueckgabedatum == null)
                {
                    a.rueckgabedatum = DateTime.Now;
                    Console.WriteLine($"Buch '{a.buch.titel}' erfolgreich zurückgegeben!");
                    return true;
                }
            }

            Console.WriteLine("Keine aktive Ausleihe für dieses Buch gefunden.");
            return false;
        }

        public void KundendetailsAusgeben(Kunde kunde)
        {
            if (kunde == null)
            {
                Console.WriteLine("Kein Kunde ausgewählt.");
            }

            Console.WriteLine("\n=== Kundendetails ===");
            Console.WriteLine($"\nKundennummer: {kunde.kundennummer}");
            Console.WriteLine($"\nName: {kunde.name}");
            Console.WriteLine($"\nAdresse; {kunde.adresse}");
            Console.WriteLine($"\n====================");

            Console.WriteLine("\nAktuelle Ausleihen:");
            bool hatAusleihen = false;
            foreach (Ausleihe a in ausleihen)
            {
                if (a.kunde == kunde && a.rueckgabedatum == null)
                {
                    Console.WriteLine($"- {a.buch.titel} (ISBN: {a.buch.isbn}) ausgeliehen am {a.ausleihdatum.ToShortDateString()}");
                    hatAusleihen = true;
                }
            }
            if (!hatAusleihen)
            {
                Console.WriteLine("Keine aktuellen Ausleihen.");
            }




        }
    }
}

