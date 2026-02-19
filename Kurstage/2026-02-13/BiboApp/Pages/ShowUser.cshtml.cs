using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class ShowUserModel : PageModel
{
    public Nutzer Nutzer { get; set; }

    public void OnGet(int id)
    {
        var db = new BiboContext();

        Nutzer = db.Nutzer
            .Include(nutzer => nutzer.AusgelieheneBücher)
            .Where(nutzer => nutzer.Id == id)
            .FirstOrDefault();
    }
}