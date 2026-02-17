using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pages.Database;

namespace Razor_Pages.Pages
{
    public class AddBookModel : PageModel

    {
        [BindProperty] public Buch NeuesBuch { get; set; } = new();
        public void OnGet()
        { }
        public IActionResult OnPost()
        { 
            var db = new BiboContext();
            db.Bücher.Add(NeuesBuch);
            db.SaveChanges(); return RedirectToPage("/ListBook");
        }


    }
    
}
