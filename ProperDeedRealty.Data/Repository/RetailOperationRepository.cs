using ProperDeedRealty.Data.Models;
using ProperDeedRealty.Data.Contracts;

namespace ProperDeedRealty.Data.Repository
{
    public class RetailOperationRepository : EFRepository<TblRetailoperationtype>, IRetailOperationRepository
    {
        public RetailOperationRepository(TheCoreBankingRetailContext context) : base(context)
        {
        }
    }
}
