using System;

namespace web.EF
{
    public class BasicModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsImported { get; set; }
        public bool NeedToReimport { get; set; }
        public DateTime ImportDate { get; set; }
        public bool IsActive { get; set; }
    }
}
