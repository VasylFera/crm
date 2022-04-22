using System;

namespace web.Data.ModelDtos
{
    public class PersonalDataDto
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string FirstName { get; set; }
        public string NoneFatherName { get; set; }
        public string PreviousLastName { get; set; }
        public string FullNamePatronymicInTheGenitiveCase { get; set; }
        public string Sex { get; set; }
        public string DateOfBirth { get; set; }
        public bool RefusalOfIndividualPersonalNumber { get; set; }
        public int IndividualPersonalNumber { get; set; }
        public string Email { get; set; }
        public bool FamilyStatus { get; set; }
        public string Note { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Filter { get; set; }
    }
}
