using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class TellerLimitRepository : EFRepository<TblTellerlimit>, ITellerLimitRepository
    {
        public TellerLimitRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblTellerlimit> GetDetailed()
        => dbSet.Where(p => p.Isdelete == false)
            .Include(t => t.Operationtype);
        //.Include(k => k.Operationtypeid);
    }
}
