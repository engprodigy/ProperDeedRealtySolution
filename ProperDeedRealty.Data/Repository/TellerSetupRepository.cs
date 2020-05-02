using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class TellerSetupRepository : EFRepository<TblTellersetup>, ITellerSetupRepository
    {
        public TellerSetupRepository(TheCoreBankingRetailContext context) : base(context) { }


        public IEnumerable<TblTellersetup> GetAllTellerSetup()
        {
            return dbSet.Where(t => t.Isdelete == false)
                 .Include(k => k.Tilllimit)
                .Include(k => k.Tillmapping);
        }


        public IQueryable<TblTellersetup> GetUserName(string username)

           => dbSet.Where(p => p.Tilluser == username);


        public TblTellersetup GetTellerSetupParam(string username, bool account)
        {
            if (account)
            {
                return dbSet.Include(k => k.Tilllimit)
                     .Include(k => k.Tillmapping)
                     .Where(u => u.Tilluser == username).FirstOrDefault();
            }

            return dbSet.Where(p => p.Tilluser == username).FirstOrDefault();
        }


    }
}
