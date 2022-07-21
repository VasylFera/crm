namespace web.Data.ModelDtos
{
    public class MilitaryAccountingSpecialtyDto
    {
        public int Id { get; set; }
        public string NameMilitaryAccountingSpecialty { get; set; }
        public int MilitaryAccountingSpecialtyCode { get; set; }      
    }

    public class MilitaryAccountingSpecialtyCodeDto
    {
        public int Id { get; set; }          
        public int Code { get; set; }
        public string NameCode { get; set; }     
      
        public int SoldierAndSergeantMilitaryAccountingSpecialtiesId { get; set; }
    }

    public class MilitaryAccountingSpecialtyLetterDto
    {
        public int Id { get; set; }
        public string Letter { get; set; }
        public string DescriptionLetter { get; set; }
    }
}
