using System;
using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class EducationProfessionalTechnicalSchoolModel:BasicModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string StatusProfessionalTechnicalSchoolCertificate { get; set; }
        public string NameProfessionalTechnicalSchool { get; set; }
        public string SeriaProfessionalTechnicalSchoolCertificate { get; set; }
        public int NumberProfessionalTechnicalSchoolCertificate { get; set; }
        public string SpecialtyProfessionalTechnicalSchool { get; set; }
        public virtual EducationDataGeneralModel EducationDataGenerals { get; set; }
    }
}
