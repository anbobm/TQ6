using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Bibliotheksverwaltung
{
    public class Kunde
    {
        // Alle Attribute/Variablen sind private.
        private int kundennummer;
        private string name;
        private string adresse;

        // Konstruktor
        public Kunde(int kundennummer, string name, string adresse)
        {
            this.kundennummer = kundennummer;
            this.name = name;
            this.adresse = adresse;
        }

        // Methoden

        // + getKundennummer() : int
        public int Kundennummer
        {
            get { return kundennummer; }
        }

        // + getName() : string
        public string Name
        {
            get { return name; }
        }

        // + setName(name : string) : void
        public void SetName(string name)
        {
            this.name = name;
        }

        // + getAdresse() : string
        public string Adresse
        {
            get { return adresse; }
        }

        // + setAdresse(adresse : string) : void
        public void SetAdresse(string adresse)
        {
            this.adresse = adresse;
        }
    }
}