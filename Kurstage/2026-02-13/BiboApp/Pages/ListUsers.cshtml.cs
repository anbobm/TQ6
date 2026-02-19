using Microsoft.AspNetCore.Mvc.RazorPages;

public class ListUsersModel : PageModel
{
    public List<Nutzer> Nutzer { get; set; }

    public void OnGet()
    {
        var db = new BiboContext();

        Nutzer = db.Nutzer.ToList();
    }
}