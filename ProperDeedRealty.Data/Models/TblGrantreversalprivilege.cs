using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblGrantreversalprivilege
    {
        public int Reversalsetupid { get; set; }
        public bool Canreversealltransaction { get; set; }
        public int? Branchid { get; set; }
        public int? Companyid { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datetimecreated { get; set; }
        public bool Isdeleted { get; set; }
        public string Deletedby { get; set; }
        public DateTime? Datetimedeleted { get; set; }
        public string Staffinformationid { get; set; }
    }
}
