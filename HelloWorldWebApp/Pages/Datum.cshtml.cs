using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldWebApp.Pages;

public class DatumModel : PageModel
{
    public string HeutigesDatum { get; set; }


    [BindProperty]
    public string eingabe { get; set; }

    public string ausgabe { get; set; }

    public void OnGet()
    {
        HeutigesDatum = DateTime.Now.ToString("dd.MM.yyyy");
    }

    public void OnPost()
    {
        HeutigesDatum = DateTime.Now.ToString("dd.MM.yyyy");
        ausgabe = $"Hallo {eingabe}";
    }

}