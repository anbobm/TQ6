using Microsoft.AspNetCore.Mvc.RazorPages;

public class ListGenresModel : PageModel
{
    public List<Genre> Genres { get; set; }

    public void OnGet()
    {
        var db = new BiboContext();

        Genres = db.Genres.ToList();
    }
}