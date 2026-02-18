using Microsoft.AspNetCore.Mvc.RazorPages;

public class ShowBookModel : PageModel
{
    public Buch Buch { get; set; }

    public void OnGet(int id)
    {
        var db = new BiboContext();

        Buch = db.Bücher.Where(buch => buch.Id == id).FirstOrDefault();
    }
}