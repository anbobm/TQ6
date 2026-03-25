using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp2.Database;

namespace WebApp2.Pages
{
    public class AddUserModel : PageModel
    {
        private readonly BiboContext _context;

        public AddUserModel(BiboContext context)
        {
            _context = context;
        }

        [BindProperty]
        [Required(ErrorMessage = "Bitte eine E-Mail eingeben.")]
        [EmailAddress(ErrorMessage = "Bitte eine gültige E-Mail eingeben.")]
        public string InputEmail { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            // optional aber sinnvoll: doppelte Emails verhindern
            bool exists = _context.Nutzer.Any(n => n.Email == InputEmail);
            if (exists)
            {
                ModelState.AddModelError(nameof(InputEmail), "Diese E-Mail existiert bereits.");
                return Page();
            }

            var user = new Nutzer
            {
                Email = InputEmail
            };

            _context.Nutzer.Add(user);
            await _context.SaveChangesAsync();

            return RedirectToPage("/ListUsers");
        }
    }
}