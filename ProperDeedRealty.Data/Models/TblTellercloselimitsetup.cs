using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblTellercloselimitsetup
    {
        public int Tellercloselimitid { get; set; }
        public decimal Amount { get; set; }
        public int Retailoperationid { get; set; }
        public int Companyid { get; set; }
        public int? Branchid { get; set; }
        public string Createdby { get; set; }
        public string Lastupdatedby { get; set; }
        public DateTime Datetimecreated { get; set; }
        public DateTime? Datetimeupdated { get; set; }
        public bool Deleted { get; set; }
        public string Deletedby { get; set; }
        public DateTime? Datetimedeleted { get; set; }

        public TblRetailoperationtype Retailoperation { get; set; }
    }
}
