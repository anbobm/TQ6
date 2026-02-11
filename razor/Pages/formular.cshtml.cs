using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor.Pages
{
    public class formularModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Name { get; set; }
        [BindProperty(SupportsGet = true)] public int? Id { get; set; }
        public Contact? Contact { get; set; }
        // Simulierte Datenbank
       
        
       private Dictionary<int, Contact> contacts = new Dictionary<int, Contact>{
        {1, new Contact() {Name = "Max Mustermann", Email = "max@mustermann.com"}},
        {2, new Contact() {Name = "Petra Schuster", Email = "petraschuster@gmail.com"}},
        { 23, new Contact() {Name = "Foo Bar", Email = "foo.bar@einfallslos.org"}},
    };
   

        public void OnGet()
        {
            if (Id.HasValue && Contacts.ContainsKey(Id.Value))
            { 
                Contact = Contacts[Id.Value]; 
            }

        }
    }
    public record Contact(int Id, string Name);
}




