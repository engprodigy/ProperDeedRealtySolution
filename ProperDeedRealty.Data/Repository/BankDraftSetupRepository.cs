using System;
using System.Collections.Generic;
using System.Text;
using ProperDeedRealty.Data.Models;
using ProperDeedRealty.Data.Contracts;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProperDeedRealty.Data.Repository
{
    public class BankDraftSetupRepository : EFRepository<TblBankdraftsetup>, IBankdraftSetupRepository
    {
        public BankDraftSetupRepository(TheCoreBankingRetailContext context) : base(context) { }

        //public IQueryable<TblBankdraftsetup> GetActive()
        //   => dbSet.Where(p => p.Isdeleted == false)
        //        .Include(k => k.Chartofaccount);

        public IQueryable<TblBankdraftsetup> GetDetailed()
           => dbSet.Where(p => p.Isdeleted == false)
                //.Include(k => k.InterestglNavigation)       
                /*.Include(k => k.PrincipalglNavigation)*/;
    }
}
