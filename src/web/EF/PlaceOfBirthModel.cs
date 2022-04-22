using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class PlaceOfBirthModel : BasicModel
    {
        [Key]
        public int Id { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string OtherData { get; set; }
    }
}
