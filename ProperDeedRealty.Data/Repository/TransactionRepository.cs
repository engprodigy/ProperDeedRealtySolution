using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class TransactionRepository : EFRepository<TblFinanceTransaction>, ITransactionRepository
    {
        public TransactionRepository(TheCoreBankingRetailContext context) : base(context) { }
        public IQueryable<TblFinanceTransaction> ValidateTransaction(int id)
        {
            return dbSet.Where(ps => ps.Id == id);
        }
        //For Stored Procedure
        public decimal SPGLBalance(string accountNo)
        {
            var GLBalance = new GLBalance();
            using (var context = new TheCoreBankingRetailContext())
            {
                SqlParameter AcctNo = new SqlParameter("@AccountID", accountNo);

                GLBalance = context.GLBalance.FromSql("General.GetGLBalance2 @AccountID", AcctNo).Single();


            }
            return GLBalance.GLBalances;
        }



        //public bool SPGLBalance(string accountNo)
        //{
        //    var result = false;
        //    using (var context = new TheCoreBankingRetailContext())
        //    {
        //        SqlParameter AcctNo = new SqlParameter("@AccountID", accountNo);

        //        context.Database.ExecuteSqlCommand("General.GetGLBalance @AccountID", AcctNo);
        //        result = true;
        //    }
        //    return result;
        //}




    }
}
