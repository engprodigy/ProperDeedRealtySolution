using System.Linq;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class COTSetupRepository : EFRepository<TblCotsetup>, ICOTSetupRepository
    {
        public COTSetupRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblCotsetup> GetActive()
            => dbSet.Where(c => c.Deleted == false);
    }
}
