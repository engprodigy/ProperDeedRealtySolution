using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface IOperationTypeRepository : IRepository<TblOperationtype>
    {
        IQueryable<TblOperationtype> GetDetailed();
    }
}
