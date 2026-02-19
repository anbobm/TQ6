using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp2.Database;

namespace WebApp2.Pages;

public class ShowUserModel : PageModel
{
    public Nutzer? Nutzer { get; set; }

    public void OnGet(int? id)
    {
        if (id == null)
        {
            Nutzer = null;
            return;
        }

        using var db = new BiboContext();

        Nutzer = db.Nutzer
            .Include(n => n.AusgelieheneBücher)   // Bücher mitladen
            .FirstOrDefault(n => n.Id == id);
    }
}
