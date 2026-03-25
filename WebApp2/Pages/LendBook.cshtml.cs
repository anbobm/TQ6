using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp2.Database;

namespace WebApp2.Pages
{
    public class LendBookModel : PageModel
    {
        private readonly BiboContext _context;

        public LendBookModel(BiboContext context)
        {
            _context = context;
        }

        [BindProperty]
        [Required(ErrorMessage = "Bitte eine Buch-Id eingeben.")]
        public int? BookId { get; set; }

        [BindProperty]
        public int? SelectedUserId { get; set; }

        public Buch? Book { get; set; }
        public List<SelectListItem> Users { get; set; } = new();

        public string? SuccessMessage { get; set; }
        public string? ErrorMessage { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostFindAsync()
        {
            await LoadUsersAsync();

            if (!ModelState.IsValid)
                return Page();

            await LoadBookAsync();

            if (Book == null)
                ErrorMessage = "Kein Buch mit dieser Id gefunden.";

            return Page();
        }

        public async Task<IActionResult> OnPostLendAsync()
        {
            await LoadUsersAsync();

            if (!ModelState.IsValid)
            {
                await LoadBookAsync();
                return Page();
            }

            var book = await _context.Bücher
                .Include(b => b.Ausleihender)
                .Include(b => b.Genre)
                .FirstOrDefaultAsync(b => b.Id == BookId!.Value);

            if (book == null)
            {
                ErrorMessage = "Buch nicht gefunden.";
                return Page();
            }

            if (book.IsAusgeliehen)
            {
                ErrorMessage = "Dieses Buch ist bereits ausgeliehen.";
                Book = book;
                return Page();
            }

            var user = await _context.Nutzer.FirstOrDefaultAsync(n => n.Id == SelectedUserId!.Value);
            if (user == null)
            {
                ErrorMessage = "Nutzer nicht gefunden.";
                Book = book;
                return Page();
            }

            book.IsAusgeliehen = true;
            book.AusleihenderId = user.Id;

            await _context.SaveChangesAsync();

            SuccessMessage = $"Erfolg: „{book.Titel}“ wurde an {user.Email} ausgeliehen.";

            await LoadBookAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostReturnAsync()
        {
            await LoadUsersAsync();

            if (BookId == null)
            {
                ModelState.AddModelError(nameof(BookId), "Bitte eine Buch-Id eingeben.");
                return Page();
            }

            var book = await _context.Bücher
                .Include(b => b.Ausleihender)
                .Include(b => b.Genre)
                .FirstOrDefaultAsync(b => b.Id == BookId.Value);

            if (book == null)
            {
                ErrorMessage = "Buch nicht gefunden.";
                return Page();
            }

            if (!book.IsAusgeliehen)
            {
                ErrorMessage = "Dieses Buch ist nicht ausgeliehen.";
                Book = book;
                return Page();
            }

            book.IsAusgeliehen = false;
            book.AusleihenderId = null;

            await _context.SaveChangesAsync();

            SuccessMessage = $"Erfolg: „{book.Titel}“ wurde zurückgegeben.";

            await LoadBookAsync();
            return Page();
        }

        private async Task LoadBookAsync()
        {
            if (BookId == null)
            {
                Book = null;
                return;
            }

            Book = await _context.Bücher
                .Include(b => b.Ausleihender)
                .Include(b => b.Genre)
                .FirstOrDefaultAsync(b => b.Id == BookId.Value);
        }

        private async Task LoadUsersAsync()
        {
            Users = await _context.Nutzer
                .OrderBy(n => n.Email)
                .Select(n => new SelectListItem
                {
                    Value = n.Id.ToString(),
                    Text = n.Email
                })
                .ToListAsync();
        }
    }
}