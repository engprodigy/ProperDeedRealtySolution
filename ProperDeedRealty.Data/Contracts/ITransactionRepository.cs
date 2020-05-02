using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface ITransactionRepository : IRepository<TblFinanceTransaction>
    {
        IQueryable<TblFinanceTransaction> ValidateTransaction(int id);

        //For Stored Procedure
        decimal SPGLBalance(string accountNo);
    }
}
