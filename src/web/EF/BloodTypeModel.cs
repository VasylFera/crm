using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class BloodTypeModel : BasicModel
    {
        [Key]
        public int Id { get; set; }
        public string BloodType { get; set; }
        public string Rhesus { get; set; }
    }
}
