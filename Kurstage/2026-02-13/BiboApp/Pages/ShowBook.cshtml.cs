using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class ShowBookModel : PageModel
{
    public Buch Buch { get; set; }

    public void OnGet(int id)
    {
        var db = new BiboContext();

        Buch = db.Bücher
            .Include(buch => buch.Ausleihender)
            .Include(buch => buch.Genre)
            .Where(buch => buch.Id == id)
            .FirstOrDefault();
    }
}