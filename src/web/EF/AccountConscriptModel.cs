using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class AccountConscriptModel :BasicModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
