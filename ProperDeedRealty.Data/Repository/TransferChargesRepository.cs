using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class TransferChargesRepository : EFRepository<TblTransfercharge>, ITransferChargesRepository
    {
        public TransferChargesRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblTransfercharge> GetActive()
        => dbSet.Where(k => k.Deleted == false)
            /*.Include(k => k.Chartofaccount)*/;

    }
}
