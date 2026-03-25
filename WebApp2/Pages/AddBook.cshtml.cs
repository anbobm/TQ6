using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp2.Database;

namespace WebApp2.Pages;

public class AddBookModel : PageModel
{
    // Eingabefelder aus dem Formular
    [BindProperty]
    public string Titel { get; set; } = "";

    [BindProperty]
    public string Autor { get; set; } = "";

    [BindProperty]
    public bool IsAusgeliehen { get; set; }

    // NEU: GenreId kommt aus dem <select asp-for="GenreId">
    [BindProperty]
    public int GenreId { get; set; }

    // NEU: Liste aller Genres für das Dropdown
    public List<Genre> Genres { get; set; } = new();

    // Seite wird per GET geöffnet -> Genres für Dropdown laden
    public void OnGet()
    {
        using var db = new BiboContext();

        Genres = db.Genres
.OrderBy(g => g.Bezeichnung.ToLower()).ToList();
    }

    // Formular wird per POST abgeschickt -> Buch speichern
    public IActionResult OnPost()
    {
        using var db = new BiboContext();

        // Wichtig: Genres wieder laden, falls wir die Page nochmal anzeigen müssen
        Genres = db.Genres
.OrderBy(g => g.Bezeichnung.ToLower()).ToList();

        // Wenn kein Genre ausgewählt wurde (GenreId = 0), Fehlermeldung anzeigen
        if (GenreId == 0)
        {
            ModelState.AddModelError("", "Bitte ein Genre auswählen.");
            return Page();
        }

        // Optional: prüfen, ob GenreId wirklich existiert
        bool genreExists = db.Genres.Any(g => g.Id == GenreId);
        if (!genreExists)
        {
            ModelState.AddModelError("", "Dieses Genre existiert nicht.");
            return Page();
        }

        var buch = new Buch
        {
            Titel = Titel,
            Autor = Autor,
            IsAusgeliehen = IsAusgeliehen,
            GenreId = GenreId
        };

        db.Bücher.Add(buch);
        db.SaveChanges();

        return RedirectToPage("/ListBooks");
    }
}
