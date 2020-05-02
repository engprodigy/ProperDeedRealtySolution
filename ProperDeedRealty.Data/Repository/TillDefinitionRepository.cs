using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class TillDefinitionRepository : EFRepository<TblTilldefinition>, ITillDefinitionRepository
    {
        public TillDefinitionRepository(TheCoreBankingRetailContext context) : base(context) { }

        public TblTilldefinition GetActive(long id)
        {
            // => dbSet.Where(p => p.Isdeleted == false);
            return dbSet.Where(t => t.Id == id && t.Isdeleted == false).FirstOrDefault();
        }

        public IQueryable<TblTilldefinition> GetDetailed()
       => dbSet.Where(p => p.Isdeleted == false);
    }
}
