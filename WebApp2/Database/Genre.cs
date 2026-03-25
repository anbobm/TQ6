namespace WebApp2.Database
{
    public class Genre
    {
        public int Id { get; set; }

        public string Bezeichnung { get; set; } = "";

        public List<Buch> Bücher { get; set; } = new();
    }
}
