using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblTillimit
    {
        public TblTillimit()
        {
            TblTellersetup = new HashSet<TblTellersetup>();
        }

        public int Id { get; set; }
        public string Tillname { get; set; }
        public string Tillfunction { get; set; }
        public string Ledgeraccount { get; set; }
        public DateTime Datecreated { get; set; }
        public string Createdby { get; set; }
        public int? Branchid { get; set; }
        public int? Companyid { get; set; }
        public bool Isdeleted { get; set; }
        public long Tillmappingid { get; set; }
        public int Tillfunctionid { get; set; }

        public TblTilltfunction TillfunctionNavigation { get; set; }
        public TblTillmapping Tillmapping { get; set; }
        public ICollection<TblTellersetup> TblTellersetup { get; set; }
    }
}
