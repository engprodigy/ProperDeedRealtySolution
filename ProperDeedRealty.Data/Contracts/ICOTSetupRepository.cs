using System.Linq;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface ICOTSetupRepository : IRepository<TblCotsetup>
    {
        IQueryable<TblCotsetup> GetActive();
    }
}
