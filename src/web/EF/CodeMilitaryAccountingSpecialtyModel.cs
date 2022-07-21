using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class CodeMilitaryAccountingSpecialtyModel:BasicModel
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int Code { get; set; }       
        public virtual SoldierAndSergeantMilitaryAccountingSpecialtyModel SoldierAndSergeantMilitaryAccountingSpecialties { get; set; }
    }
}
