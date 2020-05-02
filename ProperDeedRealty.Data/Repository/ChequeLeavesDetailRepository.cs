using ProperDeedRealty.Data.Models;
using ProperDeedRealty.Data.Contracts;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProperDeedRealty.Data.Repository
{
    public class ChequeLeavesDetailRepository : EFRepository<TblChequeleavesdetail>, IChequeLeavesDetailRepository
    {
        public ChequeLeavesDetailRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblChequeleavesdetail> GetByChequeBookID(int id) =>
            dbSet.Where(d => d.Chequebookid == id);
    }
}
