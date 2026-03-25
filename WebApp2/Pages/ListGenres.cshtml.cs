using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp2.Database;

namespace WebApp2.Pages
{
    public class ListGenresModel : PageModel
    {
        public List<Genre> Genres { get; set; } = new();

        public void OnGet()
        {
            using var db = new BiboContext();
            Genres = db.Genres.OrderBy(g => g.Id).ToList();
        }
    }
}
