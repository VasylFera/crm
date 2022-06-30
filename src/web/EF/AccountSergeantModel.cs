using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class AccountSergeantModel :BasicModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
