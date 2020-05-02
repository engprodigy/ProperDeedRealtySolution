using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblTilltfunction
    {
        public TblTilltfunction()
        {
            TblTillimit = new HashSet<TblTillimit>();
        }

        public int Id { get; set; }
        public string Tillfunction { get; set; }
        public int Functioncode { get; set; }

        public ICollection<TblTillimit> TblTillimit { get; set; }
    }
}
