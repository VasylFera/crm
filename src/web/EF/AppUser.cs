using Microsoft.AspNetCore.Identity;

namespace web.EF
{
    public class AppUser : IdentityUser
    {
        public virtual RegionModel Region { get; set; }
    }
}
