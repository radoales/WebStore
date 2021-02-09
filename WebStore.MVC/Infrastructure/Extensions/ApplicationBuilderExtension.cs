namespace WebStore.MVC.Infrastructure.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System.Threading.Tasks;
    using Data;
    using Data.Models;
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UseDatasaseMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetService<WebStoreDbContext>().Database.Migrate();

                var userManager = serviceScope.ServiceProvider.GetService<UserManager<User>>();
                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

                Task
                    .Run(async () =>
                    {
                        var adminName = WebConstants.Roles.AdminRole;

                        var roles = new[]
                        {
                            adminName,
                            WebConstants.Roles.UserRole
                        };

                        foreach (var role in roles)
                        {
                            var roleExist = await roleManager.RoleExistsAsync(role);

                            if (!roleExist)
                            {
                                await roleManager.CreateAsync(new IdentityRole
                                {
                                    Name = role
                                });
                            }
                        }

                        var adminMail = "admin@some.com";

                        var adminUser = await userManager.FindByNameAsync(adminMail);

                        if (adminUser == null)
                        {
                            adminUser = new User
                            {
                                Email = adminMail,
                                UserName = "admin",
                                PhoneNumber = "12345678",
                                FirstName = "Rado",
                                LastName = "Naydenov"
                            };

                            await userManager.CreateAsync(adminUser, "222222");

                            await userManager.AddToRoleAsync(adminUser, adminName);
                        }

                    })
                    .Wait();


                return app;
            }
        }
    }
}
