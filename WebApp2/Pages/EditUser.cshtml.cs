using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp2.Database;

namespace WebApp2.Pages
{
    public class EditUserModel : PageModel
    {
        private readonly BiboContext _context;

        public EditUserModel(BiboContext context)
        {
            _context = context;
        }

        // Damit wir beim Abbrechen/Redirect die Id kennen
        public int UserId { get; private set; }

        [BindProperty]
        [Required(ErrorMessage = "Bitte eine E-Mail eingeben.")]
        [EmailAddress(ErrorMessage = "Bitte eine gültige E-Mail eingeben.")]
        public string InputEmail { get; set; } = string.Empty;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var user = await _context.Nutzer.FirstOrDefaultAsync(n => n.Id == id);
            if (user == null)
                return NotFound();

            UserId = user.Id;
            InputEmail = user.Email;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var user = await _context.Nutzer.FirstOrDefaultAsync(n => n.Id == id);
            if (user == null)
                return NotFound();

            UserId = user.Id;

            if (!ModelState.IsValid)
                return Page();

            InputEmail = InputEmail.Trim();

            // Duplikate verhindern (case-insensitive), aber sich selbst erlauben
            bool exists = await _context.Nutzer.AnyAsync(n =>
                n.Id != id && n.Email.ToLower() == InputEmail.ToLower());

            if (exists)
            {
                ModelState.AddModelError(nameof(InputEmail), "Diese E-Mail existiert bereits.");
                return Page();
            }

            user.Email = InputEmail;
            await _context.SaveChangesAsync();

            return RedirectToPage("/ShowUser", new { id = user.Id });
        }
    }
}