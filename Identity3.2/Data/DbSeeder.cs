using Identity3._2.Models;
using Microsoft.AspNetCore.Identity;

namespace Identity3._2.Data
{
    public class DbSeeder
    {
        public static async Task Seed(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            string[] roles = { "Admin", "Staff" };

            foreach (var role in roles)
            {
                if(!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
            var admin = new ApplicationUser
            {
                UserName = "ngoctai1995@gmail.com",
                Email = "ngoctai1995@gmail.com",
                FullName = "Doan Tai",
                EmailConfirmed = true
            };
            var user = await userManager.FindByNameAsync(admin.UserName);
            if (user == null)
            {
                await userManager.CreateAsync(admin, "123456taiT_");
                await userManager.AddToRoleAsync(admin, "Admin");
            }
        }
    }
}
