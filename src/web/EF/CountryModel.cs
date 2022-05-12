using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class CountryModel : BasicModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IdentityUser User { get; set; }
    }
}
