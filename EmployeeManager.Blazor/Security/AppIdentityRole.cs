using Microsoft.AspNetCore.Identity;

namespace EmployeeManager.Blazor.Security
{
    public class AppIdentityRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
