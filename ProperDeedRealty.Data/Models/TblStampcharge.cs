using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblStampcharge
    {
        public int Id { get; set; }
        public decimal Charge { get; set; }
        public DateTime Datecreated { get; set; }
    }
}
