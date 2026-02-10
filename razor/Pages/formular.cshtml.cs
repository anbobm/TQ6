using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor.Pages
{
    public class formularModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Name { get; set; }

        public void OnGet()
        {

        }
    }
}




