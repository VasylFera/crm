using System;

namespace web.Data.ModelDtos
{
    public class PersonalDataDto
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string FirstName { get; set; }
        public string NoneFatherName { get; set; }
        public string PreviousLastName { get; set; }
        public string FullNamePatronymicInTheGenitiveCase { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string RefusalOfIndividualPersonalNumber { get; set; }
        public string IndividualPersonalNumber { get; set; }
        public string Email { get; set; }
        public bool FamilyStatus { get; set; }
        public string Note { get; set; }
        public string BloodType { get; set; }
        public string RezusTypeBlood { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Filter { get; set; }
        public string MilitaryAccountingSpecialty { get; set; }
        public string PlaceOfResidence { get; set; }
        public string  Enterprise { get; set; }
        public string MaritalStatus { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string ServiceNote { get; set; }
        public int VillageId { get; set; }
        public string VillageName { get; set; }
        public string MaritalStatusNameId { get; set; }   
        public string UserId { get; set; }
        public int StatusId { get; set; }
        public string Rank { get; set; }
    }
}
