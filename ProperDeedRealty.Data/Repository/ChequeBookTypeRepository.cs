using ProperDeedRealty.Data.Models;
using ProperDeedRealty.Data.Contracts;
using System.Linq;

namespace ProperDeedRealty.Data.Repository
{
    public class ChequeBookTypeRepository : EFRepository<TblChequebooktype>, IChequeBookTypeRepository
    {
        public ChequeBookTypeRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblChequebooktype> GetActive() =>
            dbSet.Where(t => t.Isdeleted == false);
    }
}
