using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface ITillDefinitionRepository : IRepository<TblTilldefinition>
    {
        IQueryable<TblTilldefinition> GetDetailed();
        TblTilldefinition GetActive(long id);
    }
}
