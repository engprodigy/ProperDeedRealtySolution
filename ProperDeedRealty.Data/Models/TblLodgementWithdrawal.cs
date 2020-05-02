using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblLodgementWithdrawal
    {
        public int FileId { get; set; }
        public string AccountId { get; set; }
        public string Description { get; set; }
        public byte[] FileData { get; set; }
        public string Mime { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
