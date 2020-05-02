using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblTellerlogin
    {
        public int Id { get; set; }
        public string Ledgername { get; set; }
        public string Accountid { get; set; }
        public decimal? Accountbalance { get; set; }
        public string Tellerno { get; set; }
        public DateTime? Tellerlogindate { get; set; }
        public string Tellerlogintime { get; set; }
        public bool Isactive { get; set; }
        public decimal? Closingbalance { get; set; }
        public int? Tellersetupid { get; set; }
        public int? Tellerlimitid { get; set; }
        public string Assignuser { get; set; }
        public string Username { get; set; }
        public string Branchid { get; set; }
        public string Companyid { get; set; }
    }
}
