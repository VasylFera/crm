using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class EducationDataGeneralModel:BasicModel
    {
        [Key]
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int SchoolId { get; set; }
        public int ProfessionalTechnicalSchoolId { get; set; }
        public int HigherEducationId { get; set; }
        public int ProfessionalTechnicalMilitaryId { get; set; }
        public int HigherEducationlMilitaryId { get; set; }
        public virtual PersonalDataModel PersonalData { get; set; }
    }
}
