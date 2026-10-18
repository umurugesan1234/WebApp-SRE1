using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {
            throw new InvalidOperationException("Intentional runtime error for testing the Privacy page.");
        }
    }

}
