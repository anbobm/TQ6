namespace WebApp2.Database
{
    public class Buch
    {
        public int Id { get; set; }

        public string Titel { get; set; } = "";

        public string Autor { get; set; } = "";

        public bool IsAusgeliehen { get; set; }

        // Foreign Key für Nutzer (Ausleiher)
        public int? AusleihenderId { get; set; }

        // Navigation zum Nutzer
        public Nutzer? Ausleihender { get; set; }

        // Foreign Key für Genre
        public int? GenreId { get; set; }

        // Navigation zum Genre
        public Genre? Genre { get; set; }
    }
}
