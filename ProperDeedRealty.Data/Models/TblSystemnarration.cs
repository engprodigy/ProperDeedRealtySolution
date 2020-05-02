using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblSystemnarration
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Isdefault { get; set; }
        public DateTime Datecreated { get; set; }
        public string Createdby { get; set; }
    }
}
