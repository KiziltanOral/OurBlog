using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace OurBlog.Data
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext db, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            var adminEmail = "admin@example.com";
            var adminPass = "P@ssword1";
            var adminRoleName = "Administrator";

            if (userManager.Users.Any(x => x.UserName == adminEmail))
            {
                return;
            }


        }
    }
}
