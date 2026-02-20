using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class ListBooksModel : PageModel
{
    public List<Buch> Bücher { get; set; }

    public void OnGet()
    {
        var db = new BiboContext();

        Bücher = db.Bücher
            .Include(buch => buch.Genre)
            .ToList();
    }
}