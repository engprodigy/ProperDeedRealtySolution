using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface ITellerSetupRepository : IRepository<TblTellersetup>
    {
        // IQueryable<TblTellersetup> GetDetailed();
        IEnumerable<TblTellersetup> GetAllTellerSetup();
        //TblTellersetup GetOneTeller(int TellerId);

        IQueryable<TblTellersetup> GetUserName(string username);

        TblTellersetup GetTellerSetupParam(string username, bool account);


    }
}
