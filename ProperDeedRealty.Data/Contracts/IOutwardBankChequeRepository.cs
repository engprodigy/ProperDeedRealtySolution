using System.Linq;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface IOutwardBankChequeRepository : IRepository<TblOutwardbankcheque>
    {
        IQueryable<TblOutwardbankcheque> GetNonCancelled();

        IQueryable<TblOutwardbankcheque> GetOperationRows();
    }
}
