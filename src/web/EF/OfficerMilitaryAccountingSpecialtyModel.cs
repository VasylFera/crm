using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class OfficerMilitaryAccountingSpecialtyModel : BasicModel
    {
        [Key]
        public int Id{get;set;}
        public int Code { get; set; }
    }
}
