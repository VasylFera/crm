using System;
using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class HigherEducationMilitaryModel:BasicModel
    {
        [Key]
        public int Id { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string StatusHigherEducationlMilitaryCertificate { get; set; }
        public string NameHigherEducationMilitary { get; set; }
        public string SeriaHigherEducationMilitaryCertificate { get; set; }
        public int NumberHigherEducationMilitaryCertificate { get; set; }
        public string MilitarySpecialty { get; set; }
        public virtual EducationDataGeneralModel EducationDataGenerals { get; set; }
    }
}
