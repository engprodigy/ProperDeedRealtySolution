using System.Linq;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface IChequeBookTypeRepository : IRepository<TblChequebooktype>
    {
        IQueryable<TblChequebooktype> GetActive();
    }
}
