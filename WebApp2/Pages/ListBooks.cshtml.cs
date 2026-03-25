using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp2.Database;

namespace WebApp2.Pages;

public class ListBooksModel : PageModel
{
    public List<Buch> Bücher { get; set; } = new();

    public void OnGet()
    {
        using var db = new BiboContext();

        // INSERT
        bool exists = db.Bücher.Any(b => b.Autor == "Lord Voldemort" && b.Titel.Contains("Askaban"));
        if (!exists)
        {
            db.Bücher.Add(new Buch
            {
                Autor = "Lord Voldemort",
                Titel = "Harry Potter - Der Gefangene von Askaban",
                IsAusgeliehen = false
            });
            db.SaveChanges();
        }

        // UPDATE (optional)
        var buch = db.Bücher.FirstOrDefault();
        var nutzer = db.Nutzer.FirstOrDefault();
        if (buch != null && nutzer != null)
        {
            nutzer.AusgelieheneBücher.Add(buch);
            buch.IsAusgeliehen = true;
            db.SaveChanges();
        }

        // SELECT 
        Bücher = db.Bücher
            .Include(b => b.Genre)   // neu
            //.Where(b => b.Autor.StartsWith("Lo"))
            .OrderBy(b => b.Id)
            .ToList();
    }

}

