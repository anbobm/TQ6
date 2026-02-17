using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorSaba2.Database;

namespace RazorSaba2.Pages
{
    public class AddBookModel : PageModel
    {
        [BindProperty]
        public Buch NeuesBuch { get; set; } = new();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        { 
            var db = new DB_Kontext();
            db.Bücher.Add(NeuesBuch);
            db.SaveChanges();
            return RedirectToPage("/Index"); 
        }
    }
}
