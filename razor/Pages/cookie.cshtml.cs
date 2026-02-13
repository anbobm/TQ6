using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorSaba.Pages
{
    public class cookieModel : PageModel
    {
        public string? Username { get; set; }

        public void OnGet()
        {
            Response.Cookies.Append("foo", "bar");

            Username = Request.Cookies["username"];
        }
    }
}
