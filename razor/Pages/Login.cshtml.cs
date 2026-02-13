using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorSaba.Pages
{
    public class LoginModel : PageModel
    {


        public string? Username { get; set; }

        public bool LoggedIn { get; set; }

        public void OnGet()
        {
            var username = Request.Cookies["username"];

            if (username != null)
            {
                Username = username;
                LoggedIn = true;
            }
        }

        public IActionResult OnPost(string username, string password)
        {
            Response.Cookies.Append("username", username);

            return RedirectToPage();
        }
    }
}