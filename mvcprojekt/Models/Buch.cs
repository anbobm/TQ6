/*namespace Mvcprojekt.Models
{
    internal class Buch
    {
        // Attribute
        public string isbn;
        public string titel;
        public string autor;
        public int erscheinungsjahr;

        private bool verfuegbar = true; 

        // Konstruktor
        public Buch(string isbn, string titel, string autor, int erscheinungsjahr)
        {
            this.isbn = isbn;
            this.titel = titel;
            this.autor = autor;
            this.erscheinungsjahr = erscheinungsjahr;
        }

        // Methoden
        public bool IstVerfuegbar()
        {
            return verfuegbar;
            
        }

      
        public void SetzeAusgeliehen()
        { 
            if(!verfuegbar)
            { 
            Console.WriteLine("Fehler: Das Buch ist bereits ausgeliehen!");
            return; 
            }
        
            verfuegbar = false;
            Console.WriteLine("Das Buch wurde ausgeliehen.");
        }

        public void SetzeZurueckgegeben() 
        {
    if (verfuegbar) 
    { 
        Console.WriteLine("Das Buch ist bereits zurückgegeben."); 
        return; 
    }
        verfuegbar = true;
            Console.WriteLine("Das Buch wurde zurückgegeben.");
        }


    }
}*/
namespace Mvcprojekt.Models
{
    public class Buch
    {
        public int Id { get; set; }
        public string? Titel { get; set; }
        // Wichtig für die Ausleihe
        public bool IstVerfuegbar { get; set; } = true;
    }
}
