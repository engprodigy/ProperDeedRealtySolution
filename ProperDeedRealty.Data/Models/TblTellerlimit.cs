using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblTellerlimit
    {
        public int Id { get; set; }
        public string Operationname { get; set; }
        public decimal Maxamount { get; set; }
        public decimal Minamount { get; set; }
        public int? Branchid { get; set; }
        public int? Companyid { get; set; }
        public int Operationtypeid { get; set; }
        public bool Isdelete { get; set; }

        public TblOperationtype Operationtype { get; set; }
    }
}
