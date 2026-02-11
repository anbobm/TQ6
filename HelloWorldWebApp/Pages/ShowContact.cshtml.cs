using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorldWebApp.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int? Id { get; set; }
        public string Message { get; set; } = "";
        public string ErrorMessage { get; set; }
        public Contact? FoundContact {  get; set; }
        private Dictionary<int, Contact> contacts = new Dictionary<int, Contact>{
        {1, new Contact() {Name = "Max Mustermann", Email = "max@mustermann.com"}},
        {2, new Contact() {Name = "Petra Schuster", Email = "petraschuster@gmail.com"}},
        { 23, new Contact() {Name = "Foo Bar", Email = "foo.bar@einfallslos.org"}},
    };

        public class Contact
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }

        public void OnGet()
        {
            if (Id == null)
            {
                ErrorMessage = "Bitte eine ID eingeben.";
                return;

            }

            if (contacts.TryGetValue(Id.Value, out var contact))
            {
                FoundContact = contact;
            }
            else
            {
                ErrorMessage = "Kein Contact mit dieser ID Gefunden.";
            }

        }
    }
}
