using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothek
{
    internal class Bibliothek
    {
        string name;
        string stadt;
        List<Buch> buecher;
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
        public void BuecherHinzufuegen(Buch buch)
        {
            buecher.Add(buch);
        }
    }
}

