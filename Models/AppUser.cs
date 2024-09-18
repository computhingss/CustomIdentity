using Microsoft.AspNetCore.Identity;

namespace CustomIdentity.Models
{
    public class AppUser:IdentityUser
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}
