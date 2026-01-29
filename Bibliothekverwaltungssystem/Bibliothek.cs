using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bibliotheksverwaltung
{
    public class Bibliothek
    {
        // Alle Attribute/Variablen sind private.
        private List<Buch> buecher;
        private List<Ausleihe> ausleihen;

        // Kronstruktor
        public Bibliothek()
        {
            buecher = new List<Buch>();
            ausleihen = new List<Ausleihe>();
        }

        // Methoden

        // WEG!!!
        public void BuchHinzufuegen(Buch buch)
        {
            buecher.Add(buch);
        }

        // + istVerfuegbar(buch : Buch) : boolean
        public bool IstVerfuegbar(Buch buch)
        {
            return !ausleihen.Any(a => a.Buch == buch && a.IstAktiv(DateTime.Now));
        }

        // + ausleihen(buch : Buch, kunde : Kunde, ausleihdatum : LocalDate) : boolean
        public bool Ausleihen(Buch buch, Kunde kunde, DateTime ausleihdatum)
        {
            if (!IstVerfuegbar(buch))
            {
                return false;
            }

            Ausleihe ausleihe = new Ausleihe(buch, kunde, ausleihdatum);
            ausleihen.Add(ausleihe);
            return true;
        }

        // + verlaengern(ausleihe : Ausleihe, neuesDatum : LocalDate) : boolean
        public bool Verlaengern(Ausleihe ausleihe, DateTime neuesDatum)
        {
            if (!ausleihen.Contains(ausleihe))
            {
                return false;
            }

            ausleihe.Verlaengern(neuesDatum);
            return true;
        }

        // + zurueckgeben(ausleihe : Ausleihe) : void
        public void Zurueckgeben(Ausleihe ausleihe)
        {
            ausleihen.Remove(ausleihe);
        }

        // + getAusleihenVonKunde(kunde : Kunde) : List<Ausleihe>
        public List<Ausleihe> GetAusleihenVonKunde(Kunde kunde)
        {
            return ausleihen
                .Where(a => a.Kunde == kunde)
                .ToList();
        }

        // + getAktuelleAusleihen(bibliothek : Bibliothek) : List<Ausleihe>
        public List<Ausleihe> GetAktuelleAusleihen(Kunde kunde)
        {
            return ausleihen
                .Where(a => a.Kunde == kunde && a.IstAktiv(DateTime.Now))
                .ToList();
        }
    }
}