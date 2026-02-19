using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BiboApp.Database;

namespace BiboApp.Pages
{
    public class ListBooksModel : PageModel
    {
        private readonly BiboContext _context;

        public List<Buch> Buecher { get; set; }

        public ListBooksModel(BiboContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Buecher = _context.Buecher
                .Include(b => b.GenreNavigation)
                .ToList();
        }
    }
}