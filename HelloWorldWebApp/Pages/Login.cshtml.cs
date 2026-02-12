using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldWebApp.Pages
{

    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Benutzername { get; set; }

        [BindProperty]
        public string Passwort { get; set; }

        public string? Username { get; set; }

        public void OnGet()
        {
            Username = Request.Cookies["username"];
        }
        public IActionResult OnPost()
        {
            Response.Cookies.Append("username", Benutzername);

            return RedirectToPage();
        }
    }
}
