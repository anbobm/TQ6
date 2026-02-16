using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp1.Models;

namespace WebApp1.Pages
{
    public class ShowContactModel : PageModel
    {
        
        private Dictionary<int, Contact> contacts = new Dictionary<int, Contact>
        {
            {1, new Contact { Name = "Max Mustermann", Email = "max@mustermann.com" }},
            {2, new Contact { Name = "Petra Schuster", Email = "petraschuster@gmail.com" }},
            {23, new Contact { Name = "Foo Bar", Email = "foo.bar@einfallslos.org" }},
        };

        public Contact? FoundContact { get; set; }
        public string ErrorMessage { get; set; } = "";

        public void OnGet(int? id)
        {
            if (id == null)
            {
                ErrorMessage = "Bitte eine ID angeben.";
                return;
            }

            if (contacts.TryGetValue(id.Value, out var contact))
            {
                FoundContact = contact;
            }
            else
            {
                ErrorMessage = $"Kein Kontakt mit der ID {id.Value} gefunden.";
            }
        }
    }
}
