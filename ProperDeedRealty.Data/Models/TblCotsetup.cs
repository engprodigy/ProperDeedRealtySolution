using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblCotsetup
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public string BranchCode { get; set; }
        public string CompanyCode { get; set; }
        public string FeeName { get; set; }
        public decimal FeeAmount { get; set; }
        public decimal MinTransactionAmount { get; set; }
        public int CreditLedgerId { get; set; }
        public string Remark { get; set; }
        public bool Deleted { get; set; }
    }
}
