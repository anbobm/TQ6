using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BiboApp.Database;
using System.ComponentModel.DataAnnotations;

namespace BiboApp.Pages
{
    public class AddBooksModel : PageModel
    {
        private readonly BiboContext _context;

        public AddBooksModel(BiboContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Buch NeuesBuch { get; set; }

        public SelectList GenreListe { get; set; }

        public void OnGet()
        {
            GenreListe = new SelectList(_context.Genre.ToList(), "Id", "Bezeichnung");
        }

        public IActionResult OnPost()
        {
            GenreListe = new SelectList(_context.Genre.ToList(), "Id", "Bezeichnung");

            if (!ModelState.IsValid)
            {
                return Page();
            }

            NeuesBuch.IsAusgeliehen = false;
            NeuesBuch.AusleihenderId = null;

            _context.Buecher.Add(NeuesBuch);
            _context.SaveChanges();

            return RedirectToPage("/ListBooks");
        }
    }
}