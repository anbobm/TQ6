using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp2.Database;

namespace WebApp2.Pages;

public class AddGenreModel : PageModel
{
    [BindProperty] public string Bezeichnung { get; set; } = "";

    public void OnGet() { }

    public IActionResult OnPost()
    {
        using var db = new BiboContext();

        if (string.IsNullOrWhiteSpace(Bezeichnung))
            return Page();

        db.Genres.Add(new Genre { Bezeichnung = Bezeichnung.Trim() });
        db.SaveChanges();

        return RedirectToPage("/ListGenres");
    }
}
