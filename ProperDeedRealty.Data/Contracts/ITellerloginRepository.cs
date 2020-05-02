using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface ITellerloginRepository : IRepository<TblTellerlogin>
    {
        IQueryable<TblTellerlogin> GetActive();
        IQueryable<TblTellerlogin> GetNotActive();
        IQueryable<TblTellerlogin> GetAssignedUser(string username);
    }
}
