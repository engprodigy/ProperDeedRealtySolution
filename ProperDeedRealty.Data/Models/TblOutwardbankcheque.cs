using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblOutwardbankcheque
    {
        public int Id { get; set; }
        public string Accountno { get; set; }
        public string Referenceno { get; set; }
        public string Chequeno { get; set; }
        public DateTime Chequedate { get; set; }
        public decimal Amount { get; set; }
        public DateTime Datecreated { get; set; }
        public DateTime? Cleardate { get; set; }
        public DateTime? Dateapproved { get; set; }
        public DateTime? Datecleared { get; set; }
        public decimal? Chargestampamount { get; set; }
        public bool Chargestampduty { get; set; }
        public string Bankledgerid { get; set; }
        public string Companycode { get; set; }
        public string Branchcode { get; set; }
        public int? Operationid { get; set; }
        public string Approvedby { get; set; }
        public int Approvalstatus { get; set; }
        public string Clearingremark { get; set; }
        public string Approvalremark { get; set; }
        public string Clearedby { get; set; }
        public string Operationremark { get; set; }
        public int Clearingoption { get; set; }
        public string Narration { get; set; }
        public string Createdby { get; set; }

        public TblApprovalstatus ApprovalstatusNavigation { get; set; }
        public TblClearingoptions ClearingoptionNavigation { get; set; }
    }
}
