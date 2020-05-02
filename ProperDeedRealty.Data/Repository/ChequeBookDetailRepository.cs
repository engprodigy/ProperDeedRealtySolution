using ProperDeedRealty.Data.Models;
using ProperDeedRealty.Data.Contracts;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProperDeedRealty.Data.Repository
{
    public class ChequeBookDetailRepository : EFRepository<TblChequebookdetail>, IChequeBookDetailRepository
    {
        public ChequeBookDetailRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblChequebookdetail> GetDetailed()
            => dbSet.Include(d => d.Chequebooktype);

        public IQueryable<TblChequebookdetail> GetByAccountNo(string AccountNo)
            => dbSet.Where(cb => cb.Accountno == AccountNo);

        public IQueryable<TblChequebookdetail> GetDetailedByAccountNo(string AccountNo)
            => dbSet.Where(cb => cb.Accountno == AccountNo)
                .Include(cb => cb.TblChequeleavesdetail)
                    .ThenInclude(cld => cld.LeafstatusNavigation);
    }
}
