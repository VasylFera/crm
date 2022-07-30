using System;
using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class HigherEducationModel:BasicModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string StatusHigherEducationlCertificate { get; set; }
        public string NameHigherEducation { get; set; }
        public string SeriaHigherEducationCertificate { get; set; }
        public int NumberHigherEducationCertificate { get; set; }
        public string SpecialtyHigherEducation { get; set; }
        public string ТameOfTheMilitaryDepartment { get; set; }
        public string MilitarySpecialty { get; set; }
        public virtual EducationDataGeneralModel EducationDataGenerals { get; set; }
    }
}
