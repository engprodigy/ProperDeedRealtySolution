using System;
using System.Collections.Generic;
using System.Text;
using ProperDeedRealty.Data.Models;
using ProperDeedRealty.Data.Repository;

namespace ProperDeedRealty.Data.Contracts
{
    public interface ITillMappingRepository : IRepository<TblTillmapping>
    {
        IEnumerable<TblTillmapping> GetDetails();
        TblTillmapping GetMapId(long id);
    }
}
