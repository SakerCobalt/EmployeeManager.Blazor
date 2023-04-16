using EmployeeManager.Blazor.Security;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManager.Blazor.Pages.Security
{
    [Authorize]
    public class SignoutModel : PageModel
    {
        private readonly SignInManager<AppIdentityUser> signInManager;
        public SignoutModel(SignInManager<AppIdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            await signInManager.SignOutAsync();
            return RedirectToPage("/Security/SignIn");
        }
    }
}
