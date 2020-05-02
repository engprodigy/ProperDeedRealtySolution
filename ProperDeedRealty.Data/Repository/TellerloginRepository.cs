using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class TellerloginRepository : EFRepository<TblTellerlogin>, ITellerloginRepository
    {
        public TellerloginRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblTellerlogin> GetActive()
        => dbSet.Where(p => p.Isactive == true);

        public IQueryable<TblTellerlogin> GetNotActive()
         => dbSet.Where(p => p.Isactive == false);


        public IQueryable<TblTellerlogin> GetAssignedUser(string username)

          => dbSet.Where(p => p.Isactive == true && p.Assignuser == username);
    }
}
