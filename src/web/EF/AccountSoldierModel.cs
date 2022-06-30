using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class AccountSoldierModel:BasicModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
