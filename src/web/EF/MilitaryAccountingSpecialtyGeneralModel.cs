using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class MilitaryAccountingSpecialtyGeneralModel:BasicModel
    {
        [Key]
        public int Id { get; set; }
        public int MilitaryAccountingSpecialtyCodeId { get; set; }
        public int CodeId { get; set; }      
        public int LetterId { get; set; }
        public int PersonId { get; set; }
        public virtual StatusModel StatusId { get; set; }
    }
}
