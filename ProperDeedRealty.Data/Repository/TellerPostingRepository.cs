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
    public class TellerPostingRepository : EFRepository<TblBankingCadeposit>, ITellerPostingRepository
    {
        public TellerPostingRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblBankingCadeposit> ValidateTellerPost(int postteller)
        {
            return dbSet.Where(ps => ps.Id == postteller);
        }


        #region

        //Stored procedure got Loan Disbursement
        public bool SingleFundTransfer(string accountDr, string accountCr, decimal amount, string comment, string refNo = null)
        {
            var result = false;
            using (var context = new TheCoreBankingRetailContext())
            {
                SqlParameter AccountDr = new SqlParameter("@AccountDr", accountDr);
                SqlParameter AccountCr = new SqlParameter("@AccountCr", accountCr);
                SqlParameter Amount = new SqlParameter("@Amount", amount);
                SqlParameter NarrationCr = new SqlParameter("@NarrationCr", comment);
                SqlParameter Reference = new SqlParameter("@Reference", refNo);
                context.Database.ExecuteSqlCommand("InsertFundTransfer @AccountDr,@AccountCr,@Amount,@NarrationCr,@Reference", AccountDr, AccountCr, Amount, NarrationCr, Reference);
                result = true;
            }

            return result;
        }
        #endregion
    }
}
