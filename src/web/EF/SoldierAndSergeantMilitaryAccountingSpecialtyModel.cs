using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class SoldierAndSergeantMilitaryAccountingSpecialtyModel:BasicModel
    {
        [Key]
        public int Id { get; set; }
        public int MilitaryAccountingSpecialty { get; set; }
        public string Description { get; set; }
       
    }
}
