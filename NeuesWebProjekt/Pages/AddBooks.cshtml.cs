using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NeuesWebProjekt.Database;

namespace NeuesWebProjekt.Pages
{
    public class AddBooksModel : PageModel
    {
        private readonly BiboContext _context;

        [BindProperty]
        public Buch NeuesBuch { get; set; }

        public AddBooksModel(BiboContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Buch.Add(NeuesBuch);
            await _context.SaveChangesAsync();

            return RedirectToPage("/ListBooks");
        }
    }
}