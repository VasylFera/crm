using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class StatusModel:BasicModel
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
