using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblChequebookdetail
    {
        public TblChequebookdetail()
        {
            TblChequeleavesdetail = new HashSet<TblChequeleavesdetail>();
        }

        public int Id { get; set; }
        public string Accountno { get; set; }
        public int Chequebooktypeid { get; set; }
        public decimal Charge { get; set; }
        public int Leavesno { get; set; }
        public int Startrange { get; set; }
        public int Endrange { get; set; }
        public string Remark { get; set; }
        public bool Ischarged { get; set; }
        public bool Isapproved { get; set; }
        public bool Iscountercheque { get; set; }
        public DateTime Datecreated { get; set; }
        public DateTime? Dateapproved { get; set; }

        public TblChequebooktype Chequebooktype { get; set; }
        public ICollection<TblChequeleavesdetail> TblChequeleavesdetail { get; set; }
    }
}
