using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp1.Pages
{
    public class LoginModel : PageModel
    {
        public string? Username { get; set; }

        public void OnGet()
        {
            Username = Request.Cookies["username"];    // Cookie auslesen

        }

        public void OnPost(string username, string password)
        {
            
            Response.Cookies.Append("username", username);// Cookie setzen

            
            Username = username; // Username speichern
        }
    }
}