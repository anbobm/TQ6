using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace razor.Pages{
public class formularModel : PageModel
{
   [BindProperty(SupportsGet = true)]
    public string? formular { get; set; }


    public void OnGet(string name)
    {
        if (String.IsNullOrEmpty(name))
        {
            return;
        }

        formular = $"Hallo {name}!";
    }
}

}



