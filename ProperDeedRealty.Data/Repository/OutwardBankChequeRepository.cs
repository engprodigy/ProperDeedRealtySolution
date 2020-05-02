using ProperDeedRealty.Data.Models;
using ProperDeedRealty.Data.Contracts;
using System.Linq;
using ProperDeedRealty.Data.Enums;

namespace ProperDeedRealty.Data.Repository
{
    public class OutwardBankChequeRepository : EFRepository<TblOutwardbankcheque>, IOutwardBankChequeRepository
    {
        public OutwardBankChequeRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblOutwardbankcheque> GetNonCancelled()
            => dbSet.Where(cq => cq.Approvalstatus != (int)ApprovalStatusEnum.CANCELLED);

        public IQueryable<TblOutwardbankcheque> GetOperationRows()
            => dbSet
                .Where(cq => cq.Approvalstatus == (int)ApprovalStatusEnum.APPROVED)
                .Where(cq => cq.Clearingoption != (int)ClearingOptionEnum.CLEARED);
    }
}
