using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblTilltype
    {
        public TblTilltype()
        {
            TblTillmapping = new HashSet<TblTillmapping>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<TblTillmapping> TblTillmapping { get; set; }
    }
}
