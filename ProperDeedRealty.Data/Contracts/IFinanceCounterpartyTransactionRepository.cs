﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface IFinanceCounterpartyTransactionRepository : IRepository<TblFinanceCounterpartyTransaction>
    {
        IQueryable<TblFinanceCounterpartyTransaction> ValidateCounterrparty(int counterpartyId);
    }
}
