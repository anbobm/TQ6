using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NeuesWebProjekt.Database;

namespace NeuesWebProjekt.Pages
{
    public class ShowBookModel : PageModel
    {
        private readonly BiboContext _context;

        public Buch Buch { get; set; }

        public ShowBookModel(BiboContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            Buch = await _context.Buch
                                 .FirstOrDefaultAsync(b => b.Id == id);

            if (Buch == null)
                return NotFound();

            return Page();
        }
    }
}