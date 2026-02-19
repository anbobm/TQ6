using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BiboApp.Database;

namespace BiboApp.Pages
{
    public class ShowNutzerModel : PageModel
    {
        private readonly BiboContext _context;

        public Nutzer? Nutzer { get; set; }

        public ShowNutzerModel(BiboContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            Nutzer = await _context.Nutzer
                .Include(n => n.AusgelieheneBücher)
                .FirstOrDefaultAsync(n => n.Id == id);

            if (Nutzer == null)
                return NotFound();

            return Page();
        }
    }
}