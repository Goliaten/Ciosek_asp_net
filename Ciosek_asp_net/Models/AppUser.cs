using Microsoft.AspNetCore.Identity;

namespace Ciosek_asp_net.Models
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
