using ProperDeedRealty.Data.Models;
using ProperDeedRealty.Data.Contracts;

namespace ProperDeedRealty.Data.Repository
{
    public class ChequeChargesRepository : EFRepository<TblChequecharges>, IChequeChargesRepository
    {
        public ChequeChargesRepository(TheCoreBankingRetailContext context) : base(context) { }
    }
}
