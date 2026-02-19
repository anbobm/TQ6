using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp2.Database;

namespace WebApp2.Pages
{
    public class ListUsersModel : PageModel
    {
        public List<Nutzer> NutzerListe { get; set; } = new();

        public void OnGet()
        {
            using var db = new BiboContext();

            NutzerListe = db.Nutzer
                .OrderBy(n => n.Id)
                .ToList();
        }
    }
}
