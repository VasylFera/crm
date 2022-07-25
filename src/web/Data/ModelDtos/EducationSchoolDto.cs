using System;

namespace web.Data.ModelDtos
{
    public class EducationSchoolDto
    {
        public int Id { get; set; }       
        public DateTime Start { get; set; }
        public DateTime End { get; set; }        
        public string StatusSchoolCertificate { get; set; }
        public string NumberOfClasses { get; set; }
        public string NameSchool { get; set; }
        public string SeriaSchoolCertificate { get; set; }
        public int NumberSchoolCertificate { get; set; }
           
    }

    public class EducationProfessionalTechnicalSchoolDto
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string StatusProfessionalTechnicalSchoolCertificate { get; set; }     
        public string NameProfessionalTechnicalSchool { get; set; }
        public string SeriaProfessionalTechnicalSchoolCertificate { get; set; }
        public int NumberProfessionalTechnicalSchoolCertificate { get; set; }
        public string SpecialtyProfessionalTechnicalSchool { get; set; }
    }

    public class HigherEducationDto
    {
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
    }
}
