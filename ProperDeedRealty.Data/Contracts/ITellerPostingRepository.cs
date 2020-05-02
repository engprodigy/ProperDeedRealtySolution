using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface ITellerPostingRepository : IRepository<TblBankingCadeposit>
    {
        IQueryable<TblBankingCadeposit> ValidateTellerPost(int postteller);


        //For stored Procedure
        bool SingleFundTransfer(string accountDr, string accountCr, decimal amount, string comment, string refNo = null);
    }
}
