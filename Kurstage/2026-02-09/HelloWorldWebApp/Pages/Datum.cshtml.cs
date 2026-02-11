using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class DatumModel : PageModel
{
    public string Datum { get; set; }

    public void OnGet()
    {
        Datum = DateTime.Now.ToString("dd.MM.yyyy");
    }
}