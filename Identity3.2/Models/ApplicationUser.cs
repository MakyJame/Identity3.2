using Microsoft.AspNetCore.Identity;

namespace Identity3._2.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FullName { get; set; }
    }
}
