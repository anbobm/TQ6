using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp1.Pages
{
    public class FormularModel : PageModel
    {
        public string Name { get; set; } = ""; 
        public void OnGet(string name)
        {
            Name = name;
        }
    }
}
