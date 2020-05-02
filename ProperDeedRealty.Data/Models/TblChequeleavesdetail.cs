using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblChequeleavesdetail
    {
        public int Id { get; set; }
        public int Chequebookid { get; set; }
        public int Leafstatus { get; set; }
        public int Leafno { get; set; }
        public DateTime Datecreated { get; set; }
        public string Createdby { get; set; }
        public DateTime? Dateupdated { get; set; }
        public string Updatedby { get; set; }

        public TblChequebookdetail Chequebook { get; set; }
        public TblChequeleafstatus LeafstatusNavigation { get; set; }
    }
}
