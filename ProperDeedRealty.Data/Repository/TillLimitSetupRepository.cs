using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class TillLimitSetupRepository : EFRepository<TblTilllimitsetup>, ITillLimitSetupRepository
    {
        public TillLimitSetupRepository(TheCoreBankingRetailContext context) : base(context)
        {
        }
    }
}
