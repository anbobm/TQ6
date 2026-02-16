using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NeuesWebProjekt.Database;

namespace NeuesWebProjekt.Pages
{
    public class ListBooksModel : PageModel
    {
        private readonly BiboContext _context;

        public List<Buch> Buecher { get; set; }

        public ListBooksModel(BiboContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Buecher = await _context.Buch.ToListAsync();
        }
    }
}