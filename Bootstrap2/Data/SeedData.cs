using System;
using System.Linq;
using Bootstrap2.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Bootstrap2.Models
{
    public static class SeedData
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using (var context = serviceProvider.GetRequiredService<ApplicationDbContext>())
            {
                context.Database.EnsureCreated();
                if (!context.Users.Any())
                {
                    var manager = serviceProvider.GetService<UserManager<ApplicationUser>>();
                    var user = new ApplicationUser { UserName = "john.doe@email.com" };

                    manager.CreateAsync(user, "Password1!");
                }
            }
        }
    }
}
