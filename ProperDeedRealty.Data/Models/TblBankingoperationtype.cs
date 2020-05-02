using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblBankingoperationtype
    {
        public int Id { get; set; }
        public string OperationType { get; set; }
        public string BrCode { get; set; }
        public string CoyCode { get; set; }
        public int? Class { get; set; }
    }
}
