using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class PersonalDataCountryModel: BasicModel
    {
        [Key]
        public int Id { get; set; }
        public virtual CountryModel Country { get; set; }
        public virtual RegionModel Region { get; set; }
        public virtual DistrictModel District { get; set; }
        public virtual OtgModel Otg { get; set; }
        public virtual VillageModel Village { get; set; }
        public string IdPersonal { get; set; }
    }
}
