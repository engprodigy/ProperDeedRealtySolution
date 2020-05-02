using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblBankdraftsetup
    {
        public int Bankdraftid { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public long Principalgl { get; set; }
        public long Interestgl { get; set; }
        public int Sourcebranchid { get; set; }
        public int Destinationbranchid { get; set; }
        public int Companyid { get; set; }
        public bool Israte { get; set; }
        public string Createdby { get; set; }
        public string Lastupdatedby { get; set; }
        public DateTime Datetimecreated { get; set; }
        public DateTime? Datetimeupdated { get; set; }
        public bool Isdeleted { get; set; }
        public string Deletedby { get; set; }
        public DateTime? Datetimedeleted { get; set; }
        public long? Chartofaccountid { get; set; }
    }
}
