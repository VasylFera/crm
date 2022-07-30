using System;
using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class EducationSchoolModel : BasicModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string StatusSchoolCertificate { get; set; }
        public string NumberOfClasses { get; set; }
        public string NameSchool { get; set; }
        public string SeriaSchoolCertificate { get; set; }
        public int NumberSchoolCertificate { get; set; }
        public virtual EducationDataGeneralModel EducationDataGenerals { get; set; }
    }
}
