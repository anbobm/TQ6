using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothekverwaltungsystemm
{
    internal class Ausleihe
    {
        //Attribute
        private Buch buch;
        private Kunde kunde;
        private DateOnly ausleihdatum;
        private DateOnly rueckgabedatum;


        //konstruktor
        public Ausleihe(Buch buch, Kunde kunde, DateOnly ausleihdatum)
        {
            this.buch = buch;
            this.kunde = kunde;
            this.ausleihdatum = ausleihdatum; 
            this.rueckgabedatum = default;// noch kein Rückgabedatum
         


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
