using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblTransfercharge
    {
        public int Transferchargeid { get; set; }
        public decimal Maxamount { get; set; }
        public decimal Minamount { get; set; }
        public decimal Amounttocharge { get; set; }
        public int? Branchid { get; set; }
        public int? Companyid { get; set; }
        public string Createdby { get; set; }
        public DateTime Datetimecreated { get; set; }
        public bool Deleted { get; set; }
        public string Deletedby { get; set; }
        public DateTime? Datetimedeleted { get; set; }
        public long Chartofaccountid { get; set; }
    }
}
