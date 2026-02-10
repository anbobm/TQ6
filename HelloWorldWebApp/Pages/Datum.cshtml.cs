using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldWebApp.Pages;

public class DatumModel : PageModel
{
    public string HeutigesDatum { get; set; }

    public void OnGet()
    {
        HeutigesDatum = DateTime.Now.ToString("dd.MM.yyyy");
    }
}
