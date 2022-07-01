using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class MaritalStatusModel:BasicModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
