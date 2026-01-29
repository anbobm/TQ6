using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheksverwaltung
{
    public class Ausleihe
    {
        // Alle Attribute/Variablen sind private.
        private DateTime ausleihdatum;
        private DateTime rueckgabedatum;
        private Buch buch;
        private Kunde kunde;

        // Konstruktor
        public Ausleihe(Buch buch, Kunde kunde, DateTime ausleihdatum)
        {
            this.buch = buch;
            this.kunde = kunde;
            this.ausleihdatum = ausleihdatum;
            this.rueckgabedatum = ausleihdatum.AddDays(28);
        }

        // Methoden

        // + getBuch() : Buch
        public Buch Buch
        {
            get { return buch; }
        }

        // + getKunde() : Kunde
        public Kunde Kunde
        {
            get { return kunde; }
        }

        // + getAusleihdatum() : LocalDate
        public DateTime Ausleihdatum
        {
            get { return ausleihdatum; }
        }

        // + getRueckgabedatum() : LocalDate
        public DateTime Rueckgabedatum
        {
            get { return rueckgabedatum; }
        }

        // + setRueckgabedatum(datum : LocalDate) : void
        public void SetRueckgabedatum(DateTime datum)
        {
            rueckgabedatum = datum;
        }

        // + istAktiv(heute : LocalDate) : boolean
        public bool IstAktiv(DateTime heute)
        {
            return heute <= rueckgabedatum;
        }

        // + verlaengern(neuesDatum : LocalDate) : void
        public void Verlaengern(DateTime neuesDatum)
        {
            rueckgabedatum = neuesDatum.AddDays(28);
        }
    }
}