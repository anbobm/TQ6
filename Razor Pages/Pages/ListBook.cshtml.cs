using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Pages.Database;

namespace Razor_Pages.Pages
{
    public class ListBookModel : PageModel
    {
        public List<Buch> Bücher { get; set; } = new();
        public void OnGet()
        {
            var db = new BiboContext();
            Bücher = db.Bücher.ToList();
        }
    }
}