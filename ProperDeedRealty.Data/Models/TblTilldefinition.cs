using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblTilldefinition
    {
        public TblTilldefinition()
        {
            TblTillmapping = new HashSet<TblTillmapping>();
        }

        public long Id { get; set; }
        public string Tellername { get; set; }
        public string Createdby { get; set; }
        public string Updatedby { get; set; }
        public DateTime Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }
        public string Comment { get; set; }
        public bool Isdeleted { get; set; }

        public ICollection<TblTillmapping> TblTillmapping { get; set; }
    }
}
