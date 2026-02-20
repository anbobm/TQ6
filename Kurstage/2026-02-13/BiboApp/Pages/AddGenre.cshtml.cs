using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class AddGenreModel : PageModel
{
    public IActionResult OnPost(string bezeichnung)
    {
        var db = new BiboContext();

        var genre = new Genre
        {
            Bezeichnung = bezeichnung
        };

        db.Genres.Add(genre);

        db.SaveChanges();

        return RedirectToPage("/ListGenres");
    }
}