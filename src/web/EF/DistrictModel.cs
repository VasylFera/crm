using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class DistrictModel : BasicModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }       
        public virtual RegionModel Region { get; set; }
    }
}
