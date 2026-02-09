using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldWebApp.Pages;

public class IndexModel : PageModel
{
    public string Uhrzeit { get; set; }

    public void OnGet()
    {
        Uhrzeit = DateTime.Now.TimeOfDay.ToString(@"hh\:mm");
    }
}
