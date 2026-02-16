using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp1.Pages
{
    public class DatumModel : PageModel
    {
        public string AktuellesDatum { get; set; } = "";
        
        public void OnGet() 
        {
            AktuellesDatum = DateTime.Now.ToString("dd.MM.yyyy");
        }
    }
}
