using Microsoft.AspNetCore.Identity;

namespace AspNetCoreTemplate.Data.Domain.Identity
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
    }
}
