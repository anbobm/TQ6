using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class AddBookModel : PageModel
{
    public IActionResult OnPost(string titel, string autor)
    {
        var db = new BiboContext();

        var buch = new Buch
        {
            Titel = titel,
            Autor = autor
        };

        db.Bücher.Add(buch);
        db.SaveChanges();

        return RedirectToPage("/ListBooks");
    }
}