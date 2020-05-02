using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;
namespace ProperDeedRealty.Data.Repository
{
    public class TellerCloseLimitSetupRepository : EFRepository<TellerCloseLimitSetupRepository>//, ITellerCloseLimitSetupRepository
    {
        public TellerCloseLimitSetupRepository(TheCoreBankingRetailContext context) : base(context)
        {
        }
    }
}
