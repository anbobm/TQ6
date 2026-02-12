using Microsoft.AspNetCore.Mvc.RazorPages;

public class GreetingModel : PageModel
{
    public string Greeting { get; set; }

    public void OnGet(string name)
    {
        if (String.IsNullOrEmpty(name))
        {
            return;
        }

        Greeting = $"Hallo {name}!";
    }
}




