using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothekverwaltungsystemm.Models
{
    internal class Ausleihe
    {
        //Attribute
        public Buch buch;
        public Kunde kunde;
        public DateOnly ausleihdatum;
        public DateOnly rueckgabedatum;

        // Jede Ausleihe braucht eine ID
        private static int counter = 1;
        public int Id { get; }
        //konstruktor
        public Ausleihe(Buch buch, Kunde kunde, DateOnly ausleihdatum)
        {
            this.buch = buch;
            this.kunde = kunde;
            this.ausleihdatum = ausleihdatum; 
            this.rueckgabedatum = default;// noch kein Rückgabedatum
            this.Id = counter++;
         


        }

        public void starteAusleihe()
        {
            buch.SetzeAusgeliehen(); 
            kunde.buchAusleihen(this); 
        }

        public void beendeAusleihe() 
        { 
            buch.SetzeZurueckgegeben();
            kunde.buchZureckgeben(this); 
            rueckgabedatum = DateOnly.FromDateTime(DateTime.Now);
        }
        // Rückgabedatum ändern
        public void aendereRueckgabedatum(DateOnly neuesDatum)
        { 
            rueckgabedatum = neuesDatum;
        }
        public void setzeAusleihdatum(DateOnly datum) 
        { 
            ausleihdatum = datum; 
        }

        // Rückgabedatum setzen
        public void setzeRueckgabedatum(DateOnly datum) 
        {
            rueckgabedatum = datum; 
        }
          
    }
}
