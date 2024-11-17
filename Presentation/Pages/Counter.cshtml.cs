using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentation.Pages;

public class CounterModel : PageModel
{
    public int CurrentCount { get; set; }

    public void OnGet()
    {
        
    }

    public void OnPost()
    {
        CurrentCount++;
    }
}