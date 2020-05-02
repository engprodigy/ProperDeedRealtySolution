using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblChequebooktype
    {
        public TblChequebooktype()
        {
            TblChequebookdetail = new HashSet<TblChequebookdetail>();
        }

        public int Id { get; set; }
        public string Chequetype { get; set; }
        public decimal? Charge { get; set; }
        public int Leavesno { get; set; }
        public string Remark { get; set; }
        public string Creditledger { get; set; }
        public bool Isdeleted { get; set; }

        public ICollection<TblChequebookdetail> TblChequebookdetail { get; set; }
    }
}
