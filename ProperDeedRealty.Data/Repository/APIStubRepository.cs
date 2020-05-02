using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class APIStubRepository : EFRepository<APIStubModel>, IAPIStubRepository
    {
        public APIStubRepository(TheCoreBankingRetailContext context) : base(context) { }
    }



}
