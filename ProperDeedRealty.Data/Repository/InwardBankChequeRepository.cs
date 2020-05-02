using ProperDeedRealty.Data.Models;
using ProperDeedRealty.Data.Contracts;

namespace ProperDeedRealty.Data.Repository
{
    public class InwardBankChequeRepository : EFRepository<TblInwardbankcheque>, IInwardBankChequeRepository
    {
        public InwardBankChequeRepository(TheCoreBankingRetailContext context) : base(context) { }
    }
}
