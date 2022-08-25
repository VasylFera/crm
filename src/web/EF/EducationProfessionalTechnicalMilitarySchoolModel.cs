using System;
using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class EducationProfessionalTechnicalMilitarySchoolModel : BasicModel
    {
        [Key]
        public int Id { get; set; }
        public string RVCReferralNumber { get; set; }
        public string RVCReferralDate { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string NameProfessionalTechnicalMilitarySchool { get; set; }
        public string SpecialtyProfessionalTechnicalMilitarySchool { get; set; }
        public virtual EducationDataGeneralModel EducationDataGenerals { get; set; }
    }
}
