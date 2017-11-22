using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTemplate.Data.Core;
using AspNetCoreTemplate.Data.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreTemplate.Client.Web.Initialization
{
    public class DatabaseInitializer
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<MainContext>();

                //var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                //var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

                await ApplyMigrations(context);

                SeedDatabase();
            }
        }

        private static async Task ApplyMigrations(MainContext context)
        {
            await context.Database.MigrateAsync();
        }

        private static void SeedDatabase()
        {
            
        }
    }
}
