using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class SingleFundTransferRepository : EFRepository<TblBankingsinglefundtransfer>, ISingleFundTransferRepository
    {
        public SingleFundTransferRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblBankingsinglefundtransfer> ValidateSinglefundtransn(int fundtrans)
        {
            return dbSet.Where(c => c.Id == fundtrans);
        }
    }
}

