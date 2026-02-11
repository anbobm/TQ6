using Microsoft.AspNetCore.Mvc.RazorPages;

public class CookieModel : PageModel
{
    public string Username { get; set; }
    public void OnGet()
    {
        Response.Cookies.Append("foo", "bar");
        
        Username = Request.Cookies["username"];
    }
}