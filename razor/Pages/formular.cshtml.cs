using Microsoft.AspNetCore.Mvc.RazorPages;

public class formularModel : PageModel
{
    public string formular { get; set; }

    public void OnGet(string name)
    {
        if (String.IsNullOrEmpty(name))
        {
            return;
        }

        formular = $"Hallo {name}!";
    }
}



