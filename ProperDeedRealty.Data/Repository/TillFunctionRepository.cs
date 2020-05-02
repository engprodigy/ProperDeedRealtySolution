using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class TillFunctionRepository : EFRepository<TblTilltfunction>, ITillFunctionRepository
    {
        public TillFunctionRepository(TheCoreBankingRetailContext context) : base(context) { }


    }
}
