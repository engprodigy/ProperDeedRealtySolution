using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblOperationtype
    {
        public TblOperationtype()
        {
            TblTellerlimit = new HashSet<TblTellerlimit>();
        }

        public int Id { get; set; }
        public string Operationname { get; set; }
        public bool? Isactive { get; set; }
        public bool Isdeleted { get; set; }
        public int Operationcode { get; set; }
        public DateTime? Datedeleted { get; set; }
        public string Deletedby { get; set; }
        public int? Companyid { get; set; }
        public int? Branchid { get; set; }

        public ICollection<TblTellerlimit> TblTellerlimit { get; set; }
    }
}
