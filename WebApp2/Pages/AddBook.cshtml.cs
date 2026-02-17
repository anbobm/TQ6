using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp2.Database;

namespace WebApp2.Pages;

public class AddBookModel : PageModel
{
    [BindProperty]
    public string Titel { get; set; } = "";

    [BindProperty]
    public string Autor { get; set; } = "";

    [BindProperty]
    public bool IsAusgeliehen { get; set; }

    public IActionResult OnPost()
    {
        using var db = new BiboContext();

        var buch = new Buch
        {
            Titel = Titel,
            Autor = Autor,
            IsAusgeliehen = IsAusgeliehen
        };

        db.Bücher.Add(buch);
        db.SaveChanges();

        return RedirectToPage("/Index");
    }
}
