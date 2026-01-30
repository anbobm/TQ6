using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheksverwaltungssystem
{
    internal class Ausleihe
    {
        // Attribute
        private Buch buch;
        private Kunde kunde;
        private DateOnly ausleihdatum;
        private DateOnly rueckgabedatum;

        //Konstruktor
        public Ausleihe(Buch buch, Kunde kunde)
        {
            this.buch = buch;
            this.kunde = kunde;
        }

        //Methoden
        public void StarteAusleihe()
        {
            SetzeAusleihdatum();
            buch.SetzeAusgeliehen();
        }
        
        public void BeendeAusleihe()
        {
            SetzeRueckgabedatum();
            buch.SetzeVerfuegbar();
        }

        public void AendereRueckgabedatum(DateOnly neuesRueckgabedatum)
        {
            rueckgabedatum = neuesRueckgabedatum;
        }

        private void SetzeAusleihdatum()
        {
            ausleihdatum = DateOnly.FromDateTime(DateTime.Now);
        }

        private void SetzeRueckgabedatum()
        {
            rueckgabedatum = DateOnly.FromDateTime(DateTime.Now);
        }



    }
}
