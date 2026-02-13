using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorSaba.Pages
{
    public class ShowContactModel : PageModel
    {
        public bool ContactFound { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";

        public void OnGet()
        {
            var id = Request.Query["id"];

            if (id == "1")
            {
                ContactFound = true;
                Name = "Max";
                Email = "max@test.de";
            }
            else
            {
                ContactFound = false;
            }
        }
    }
}