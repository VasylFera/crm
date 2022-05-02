using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class VillageModel : BasicModel
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
