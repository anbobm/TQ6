namespace BiboApp.Database
{
    public class Nutzer
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public List<Buch> AusgelieheneBücher { get; set; } = new();
    }
}