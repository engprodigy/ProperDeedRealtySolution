using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblTillmapping
    {
        public TblTillmapping()
        {
            TblTellersetup = new HashSet<TblTellersetup>();
            TblTillimit = new HashSet<TblTillimit>();
        }

        public long Id { get; set; }
        public string Accountid { get; set; }
        public int Tilltypeid { get; set; }
        public long Chartofaccountid { get; set; }
        public long Tilldefinationid { get; set; }
        public string Tilldefinationname { get; set; }
        public string Createdby { get; set; }
        public string Updatedby { get; set; }
        public bool Isdeleted { get; set; }
        public DateTime Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }

        public TblTilldefinition Tilldefination { get; set; }
        public TblTilltype Tilltype { get; set; }
        public ICollection<TblTellersetup> TblTellersetup { get; set; }
        public ICollection<TblTillimit> TblTillimit { get; set; }
    }
}
