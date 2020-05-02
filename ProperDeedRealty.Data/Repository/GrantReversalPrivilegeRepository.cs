using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class GrantReversalPrivilegeRepository : EFRepository<TblGrantreversalprivilege>, IGrantReversalPrivilegeRepository
    {
        public GrantReversalPrivilegeRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblGrantreversalprivilege> GetActive()
        => dbSet.Where(k => k.Isdeleted == false)
            /*.Include(i => i.Staffinformation)*/;
    }
}
