using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblChequecharges
    {
        public int Id { get; set; }
        public decimal Percentage { get; set; }
        public int Accountledgerid { get; set; }
        public decimal Maxamount { get; set; }
        public bool Isdiscountcharge { get; set; }
        public bool Isreturncharge { get; set; }
        public DateTime Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }
        public string Branchcode { get; set; }
        public string Companycode { get; set; }
    }
}
