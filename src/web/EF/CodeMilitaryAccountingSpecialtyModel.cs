using System.ComponentModel.DataAnnotations;

namespace web.EF
{
    public class CodeMilitaryAccountingSpecialtyModel:BasicModel
    {
        [Key]
        public int Id { get; set; }
        public int Code { get; set; }
        public string Letter { get; set; }
    }
}
