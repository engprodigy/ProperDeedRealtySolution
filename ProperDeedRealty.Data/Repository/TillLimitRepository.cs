using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class TillLimitRepository : EFRepository<TblTillimit>, ITillLimitRepository
    {
        public TillLimitRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblTillimit> GetDetailed()
       => dbSet.Where(t => t.Isdeleted == false)
            .Include(k => k.TillfunctionNavigation)
            .Include(k => k.Tillmapping);


    }
}
