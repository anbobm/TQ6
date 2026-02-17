using Microsoft.AspNetCore.Mvc.RazorPages;

public class ListBooksModel : PageModel
{
    public List<Buch> Bücher { get; set; }

    public void OnGet()
    {
        var db = new BiboContext();

        Bücher = db.Bücher.ToList();
    }
}