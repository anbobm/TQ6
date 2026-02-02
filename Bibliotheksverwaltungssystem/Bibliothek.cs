using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Bibliotheksverwaltungssystem
{
    internal class Bibliothek
    {
        //Attribute
        private List<Buch> buecher;
        private List<Ausleihe> ausleihen;
        private List<Kunde> kunden;

        //Konstruktor
        public Bibliothek()
        {
            buecher = new List<Buch>();
            ausleihen = new List<Ausleihe>();
            kunden = new List<Kunde>();
        }

        //Methoden
        public Kunde KundeErstellen(int nummer, string name, string adresse)
        {
            Kunde kunde = new Kunde(nummer, name, adresse);
            kunden.Add(kunde);
            return kunde;
        }

        public bool KundeLoeschen(int kundennummer)
        {
            foreach (Kunde kunde in kunden)
            {
                if (kunde.Kundennummer == kundennummer)
                {
                    kunden.Remove(kunde);
                    return true;
                }
            }
            return false;
        }

        public bool AusleihProzessStarten(Buch buch, Kunde kunde)
        {
            if (PruefeBuchVerfuegbarkeit(buch))
            {
                if (kunde.AnzahlAusleihen() < 5)
                {


                    Ausleihe ausleihe = new Ausleihe(buch, kunde);
                    ausleihe.StarteAusleihe();

                    ausleihen.Add(ausleihe);
                    kunde.BuchAusleihen(ausleihe);

                    return true;
                }
            }
            return false;
        }

        public bool AusleihProzessAendern(Ausleihe ausleihe, DateOnly neuesRueckgabedatum)
        {
            if (ausleihe != null)
            {
                ausleihe.AendereRueckgabedatum(neuesRueckgabedatum);
                return true;
            }
            return false;
        }

        private bool PruefeBuchVerfuegbarkeit(Buch buch)
        {
            return buch.IstVerfuegbar();
        }



    }
}
