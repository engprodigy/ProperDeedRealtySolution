using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface ITillTypeRepository : IRepository<TblTilltype>
    {
        //IEnumerable<TblTilltype> GetDetailed();
    }
}
