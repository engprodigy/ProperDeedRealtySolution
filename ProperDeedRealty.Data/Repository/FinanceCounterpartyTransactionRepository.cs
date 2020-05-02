using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class FinanceCounterpartyTransactionRepository : EFRepository<TblFinanceCounterpartyTransaction>, IFinanceCounterpartyTransactionRepository
    {
        public FinanceCounterpartyTransactionRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblFinanceCounterpartyTransaction> ValidateCounterrparty(int counterpartyId)
        {
            return dbSet.Where(ft => ft.TransactionId == counterpartyId);
        }
    }
}
