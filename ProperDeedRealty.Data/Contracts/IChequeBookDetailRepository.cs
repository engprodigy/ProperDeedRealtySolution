using System.Linq;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface IChequeBookDetailRepository : IRepository<TblChequebookdetail>
    {
        IQueryable<TblChequebookdetail> GetDetailed();
        IQueryable<TblChequebookdetail> GetByAccountNo(string AccountNo);
        IQueryable<TblChequebookdetail> GetDetailedByAccountNo(string AccountNo);
    }
}
