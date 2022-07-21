using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class MilitaryAccountingSpecialtyLetterModel :BasicModel
    {
        [Key]
        public int Id { get; set; }
        public string Letter { get; set; }
        public string DescriptionLetter { get; set; }
        public virtual CodeMilitaryAccountingSpecialtyModel CodeMilitaryAccountingSpecialties { get; set; }
    }
}
