using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class AddBookModel : PageModel
{
    public List<Genre> Genres { get; set; }

    public void OnGet()
    {
        var db = new BiboContext();

        Genres = db.Genres.ToList();
    }

    public IActionResult OnPost(string titel, string autor, int genre)
    {
        var db = new BiboContext();

        var genreObjekt = db.Genres.Where(g => g.Id == genre).FirstOrDefault();

        var buch = new Buch
        {
            Titel = titel,
            Genre = genreObjekt
        };

        db.Bücher.Add(buch);
        db.SaveChanges();

        return RedirectToPage("/ListBooks");
    }
}