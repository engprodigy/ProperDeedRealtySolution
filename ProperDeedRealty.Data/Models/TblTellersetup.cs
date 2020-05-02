using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblTellersetup
    {
        public int Id { get; set; }
        public string Tillname { get; set; }
        public string Tilluser { get; set; }
        public decimal Tilllimitamount { get; set; }
        public string Tellertillaccount { get; set; }
        public string Tillaccountnumber { get; set; }
        public int Tilllimitid { get; set; }
        public string Createdby { get; set; }
        public int Branchid { get; set; }
        public int Companyid { get; set; }
        public DateTime Datecreated { get; set; }
        public bool Isdelete { get; set; }
        public long? Tillmappingid { get; set; }
        public string Staffinformationid { get; set; }

        public TblTillimit Tilllimit { get; set; }
        public TblTillmapping Tillmapping { get; set; }
    }
}
