using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace razor.Pages
{
    public class DatumModel : PageModel
    {
        public string Heute { get; set;  } //model
       public void OnGet()

        {
            Heute = DateTime.Now.ToString("dd.MM.yyyy");
        }
    }
}
