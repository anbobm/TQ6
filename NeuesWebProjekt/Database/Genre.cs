namespace BiboApp.Database
{
    public class Genre
    {
        public int Id { get; set; }
        public string Bezeichnung { get; set; }

        public ICollection<Buch>? Buecher { get; set; }
    }
}