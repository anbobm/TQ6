using System.ComponentModel.DataAnnotations.Schema;

public class Buch
{
    public int Id { get; set; }

    public string Titel { get; set; }

    public bool IsAusgeliehen { get; set; }

    public Nutzer? Ausleihender { get; set; }

    public Genre? Genre { get; set; }

    public List<Autor> Autoren { get; set; }
}