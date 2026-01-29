using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothek
{
    internal class Kunde
    {
        public string kundennummer;
        public string name;
        public string adresse;

        //konstruktor
        public Kunde(string kundennummer, string name, string adresse)
        {
            this.kundennummer = kundennummer;
            this.name = name;
            this.adresse = adresse;
        }
    }
}
