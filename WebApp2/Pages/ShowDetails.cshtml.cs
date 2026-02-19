using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp2.Database;

namespace WebApp2.Pages;

public class ShowDetailsModel : PageModel
{
    // Eigenschaft für das Buch, das angezeigt werden soll
    public Buch? Buch { get; set; }

    // OnGet wird aufgerufen, wenn die Seite geladen wird
    public void OnGet(int? id)
    {
        // Wenn keine ID übergeben wurde → kein Fehler, nur nichts anzeigen
        if (id == null)
        {
            Buch = null;
            return;
        }

        // Datenbank öffnen
        using var db = new BiboContext();


        Buch = db.Bücher
                   .Include(b => b.Ausleihender)   
                   .FirstOrDefault(b => b.Id == id);
    }
}

