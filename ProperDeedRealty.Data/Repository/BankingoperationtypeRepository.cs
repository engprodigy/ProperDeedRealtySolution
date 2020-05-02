using System;
using System.Collections.Generic;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class BankingoperationtypeRepository : EFRepository<TblBankingoperationtype>, IBankingoperationtypeRepository
    {
        public BankingoperationtypeRepository(TheCoreBankingRetailContext context) : base(context) { }
    }
}
