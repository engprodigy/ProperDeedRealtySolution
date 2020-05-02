using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface ITillLimitRepository : IRepository<TblTillimit>
    {
        IQueryable<TblTillimit> GetDetailed();
    }
}
