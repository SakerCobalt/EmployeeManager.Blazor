
using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.Blazor.Security
{
    public class AppIdentityDbContext : IdentityDbContext<AppIdentityUser, AppIdentityRole, string>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) :base(options)
        {
            
        }

    }
}
