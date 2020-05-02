using ProperDeedRealty.Data.Models;
using ProperDeedRealty.Data.Contracts;

namespace ProperDeedRealty.Data.Repository
{
    public class StampChargeRepository : EFRepository<TblStampcharge>, IStampChargeRepository
    {
        public StampChargeRepository(TheCoreBankingRetailContext context) : base(context) { }
    }
}
