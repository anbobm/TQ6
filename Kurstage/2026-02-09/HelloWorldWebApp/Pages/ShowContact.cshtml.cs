using Microsoft.AspNetCore.Mvc.RazorPages;

public class ShowContactModel : PageModel
{
    private Dictionary<int, Contact> contacts = new Dictionary<int, Contact>{
        {1, new Contact() {Name = "Max Mustermann", Email = "max@mustermann.com"}},
        {2, new Contact() {Name = "Petra Schuster", Email = "petraschuster@gmail.com"}},
        {23, new Contact() {Name = "Foo Bar", Email = "foo.bar@einfallslos.org"}},
    };

    public string Name { get; set; }

    public string Email { get; set; }

    public bool ContactFound { get; set; } = false;

    public void OnGet(int id)
    {
        if (contacts.ContainsKey(id))
        {
            var contact = contacts[id];

            Name = contact.Name;
            Email = contact.Email;
            ContactFound = true;
        }
    }
}

public class Contact
{
    public string Name { get; set; }

    public string Email { get; set; }
}