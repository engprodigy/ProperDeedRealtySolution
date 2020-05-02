using System;
using System.Collections.Generic;

namespace ProperDeedRealty.Data.Models
{
    public partial class TblClearingoptions
    {
        public TblClearingoptions()
        {
            TblOutwardbankcheque = new HashSet<TblOutwardbankcheque>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblOutwardbankcheque> TblOutwardbankcheque { get; set; }
    }
}
