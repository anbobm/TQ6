using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NeuesWebProjekt.Database;

namespace NeuesWebProjekt.Pages
{
    public class NutzerModel : PageModel
    {
        private readonly BiboContext _context;

        public List<Nutzer> NutzerListe { get; set; }

        public NutzerModel(BiboContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            NutzerListe = await _context.Nutzer.ToListAsync();
        }
    }
}