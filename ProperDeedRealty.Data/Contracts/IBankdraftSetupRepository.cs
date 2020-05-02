using System.Linq;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface IBankdraftSetupRepository : IRepository<TblBankdraftsetup>
    {
        //IQueryable<TblBankdraftsetup> GetActive();

        IQueryable<TblBankdraftsetup> GetDetailed();
    }
}
