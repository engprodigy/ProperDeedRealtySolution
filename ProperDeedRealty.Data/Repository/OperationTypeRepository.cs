using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class OperationTypeRepository : EFRepository<TblOperationtype>, IOperationTypeRepository
    {
        public OperationTypeRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblOperationtype> GetDetailed()
        => dbSet.Where(p => p.Isdeleted == false && p.Isactive == true);
    }
}
