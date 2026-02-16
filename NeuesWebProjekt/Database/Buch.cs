namespace NeuesWebProjekt.Database
{
    public class Buch
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Autor { get; set; }
        public bool IsAusgeliehen { get; set; }
    }
}