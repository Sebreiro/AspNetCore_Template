using AspNetCoreTemplate.Data.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTemplate.Data.Core
{
    public class MainContext: IdentityDbContext<ApplicationUser, ApplicationRole, string> 
    {
        //public DbSet<TestModel> TestModel { get; set; }

        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

    }


}
