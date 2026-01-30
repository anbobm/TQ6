using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheksverwaltungssystem
{
    internal class Kunde
    {
        // Attribute
        private int kundennummer;
        private string name;
        private string adresse;
        private List<Ausleihe> ausleihen;
        // Konstruktor
        public Kunde(int kundennummer, string name, string adresse)
        {
            this.kundennummer = kundennummer;
            this.name = name;
            this.adresse = adresse;
            this.ausleihen = new List<Ausleihe>();
        }

        // Methoden
        public bool BuchAusleihen(Ausleihe ausleihe)
        {
            if (PruefeAusleihLimit())
            {
                ausleihen.Add(ausleihe);
                return true;
            }
            return false;
        }

        public bool BuchZurueckgeben(Ausleihe ausleihe)
        {
            return ausleihen.Remove(ausleihe);
        }

        public int AnzahlAusleihen()
        {
            return ausleihen.Count;
        }

        private bool PruefeAusleihLimit()
        {
            return ausleihen.Count < 5;
        }

        public int Kundennummer
        {
            get { return kundennummer; }
        }

        public string Name
        {
            get { return name; }
        }

        public override string ToString()
        {
            return $"Kunde {kundennummer}: {name} ({ausleihen.Count} Ausleihen)";
        }

        public void KundendetailsAnzeigen()
        {
            Console.WriteLine("===== KUNDENDETAILS =====");
            Console.WriteLine($"Kundennummer : {kundennummer}");
            Console.WriteLine($"Name         : {name}");
            Console.WriteLine($"Adresse      : {adresse}");
            Console.WriteLine($"Ausleihen    : {ausleihen.Count}");
            Console.WriteLine("=========================");
        }
    }
}
