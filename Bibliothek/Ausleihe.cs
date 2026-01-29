using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothek
{
    internal class Ausleihe
    {
        public Buch buch;
        public Kunde kunde;
        public DateTime ausleihdatum;
        public DateTime? rueckgabedatum;

        public Ausleihe(Buch buch, Kunde kunde)
        {
            this.buch = buch;
            this.kunde = kunde;
            ausleihdatum = DateTime.Now;
            rueckgabedatum = null;
        }
    }
}
