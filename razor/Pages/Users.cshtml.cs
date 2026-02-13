using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor.Pages
{
    public class UsersModel : PageModel
    {
        public List<User> Users { get; set; } = new();

        public void OnGet()
        {
            // Beispiel-Daten, damit die Seite funktioniert
            Users = new List<User>
            {
                new User { Username = "Max" },
                new User { Username = "Petra" }
            };
        }
    }
}
