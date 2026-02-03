/*

namespace Mvcprojekt.Models
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
}*/
namespace Mvcprojekt.Models
{
    public class Ausleihe
    {
        public int Id { get; set; }

        // Buch
        public int BuchId { get; set; }
        public Buch Buch { get; set; }

        // Kunde
        public int KundeId { get; set; }
        public Kunde Kunde { get; set; }

        // Daten
        public DateTime Ausleihdatum { get; set; }
        public DateTime?
            Rueckgabedatum
        { get; set; }
        // 👉 HIER kommt dein Konstruktor hin
        public Ausleihe(Buch buch, Kunde kunde, DateTime ausleihdatum)
        {
            Buch = buch; Kunde = kunde; Ausleihdatum = ausleihdatum; Rueckgabedatum = null;
        } 
        public void starteAusleihe()
        {
            Ausleihdatum = DateTime.Now;
            if (Buch != null) Buch.IstVerfuegbar = false;
        }
        public void beendeAusleihe() 
        {
            Rueckgabedatum = DateTime.Now;
            if (Buch != null) Buch.IstVerfuegbar = true;
        }

    }
}