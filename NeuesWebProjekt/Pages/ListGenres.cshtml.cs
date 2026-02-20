using Microsoft.AspNetCore.Mvc.RazorPages;
using BiboApp.Database;
using System.Collections.Generic;
using System.Linq;

namespace BiboApp.Pages
{
    public class ListGenresModel : PageModel
    {
        private readonly BiboContext _context;

        public List<Genre> Genres { get; set; }

        public ListGenresModel(BiboContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Genres = _context.Genre.ToList();
        }
    }
}