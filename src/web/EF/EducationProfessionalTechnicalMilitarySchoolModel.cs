using System;
using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class EducationProfessionalTechnicalMilitarySchoolModel : BasicModel
    {
        [Key]
        public int Id { get; set; }
        public string RVCReferralNumber { get; set; }
        public DateTime RVCReferralDate { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string NameProfessionalTechnicalMilitarySchool { get; set; }
        public string SpecialtyProfessionalTechnicalMilitarySchool { get; set; }
        public virtual EducationDataGeneralModel EducationDataGenerals { get; set; }
    }
}
