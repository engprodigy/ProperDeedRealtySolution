using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class TillMappingRepository : EFRepository<TblTillmapping>, ITillMappingRepository
    {
        public TillMappingRepository(TheCoreBankingRetailContext context) : base(context) { }

        public TblTillmapping GetMapId(long id)
        {
            return dbSet.Where(t => t.Id == id && t.Isdeleted == false).FirstOrDefault();
        }

        public IEnumerable<TblTillmapping> GetDetails()
        {
            return dbSet.Where(p => p.Isdeleted == false)
                 .Include(t => t.Tilldefination)
                 .Include(t => t.Tilltype);
        }


    }
}
