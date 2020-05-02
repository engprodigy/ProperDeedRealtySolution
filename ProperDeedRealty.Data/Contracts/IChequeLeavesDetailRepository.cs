using System.Linq;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface IChequeLeavesDetailRepository : IRepository<TblChequeleavesdetail>
    {
        IQueryable<TblChequeleavesdetail> GetByChequeBookID(int id);
    }
}
