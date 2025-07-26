using Microsoft.AspNetCore.Identity;

namespace MV-API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
