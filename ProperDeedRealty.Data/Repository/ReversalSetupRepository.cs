using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class ReversalSetupRepository : EFRepository<TblReversalsetup>, IReversalSetupRepository
    {
        public ReversalSetupRepository(TheCoreBankingRetailContext context) : base(context)
        {
        }
    }
}
