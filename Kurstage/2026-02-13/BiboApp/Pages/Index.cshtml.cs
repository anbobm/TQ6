using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Foo.Pages;

public class IndexModel : PageModel
{
    public List<Buch> Bücher { get; set; }

    public void OnGet()
    {
        // var db = new BiboContext();

        // // "SELECT * FROM Bücher WHERE Autor LIKE 'To%' ORDER BY Titel"
        // Bücher = db.Bücher.Where(buch => buch.Autor.StartsWith("Lo"))
        //     .OrderBy(buch => buch.Titel).ToList();

        // // "INSERT INTO Bücher VALUES(..)"
        // var buch = new Buch
        // {
        //     Autor = "Lord Voldemort",
        //     Titel = "Harry Potter - Der Gefangene von Askaban",
        //     IsAusgeliehen = false
        // };
        // db.Bücher.Add(buch);
        // db.SaveChanges();

        // // UPDATE Bücher SET AusleihenderId = ... WHERE Id = ...
        // buch = db.Bücher.First();
        // var nutzer = db.Nutzer.First();
        // nutzer.AusgelieheneBücher.Add(buch);
        // db.SaveChanges();
    }
}
