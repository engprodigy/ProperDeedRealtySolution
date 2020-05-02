using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class TillTypeRepository : EFRepository<TblTilltype>, ITillTypeRepository
    {
        public TillTypeRepository(TheCoreBankingRetailContext context) : base(context) { }


    }
}
