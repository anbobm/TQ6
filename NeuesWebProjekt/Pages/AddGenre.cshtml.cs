using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BiboApp.Database;
using System.ComponentModel.DataAnnotations;

namespace BiboApp.Pages
{
    public class AddGenreModel : PageModel
    {
        private readonly BiboContext _context;

        public AddGenreModel(BiboContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Genre NeuesGenre { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Genre.Add(NeuesGenre);
            _context.SaveChanges();

            return RedirectToPage("/ListGenres");
        }
    }
}