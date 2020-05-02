using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Repository
{
    public class StaffInformaionRepository : EFRepository<TblStaffInformation>, IStaffInformaionRepository
    {
        public StaffInformaionRepository(TheCoreBankingRetailContext context) : base(context) { }

        public IQueryable<TblStaffInformation> ValidateStaffInfo(int ID)
        {
            return dbSet.Where(s => s.Id == ID);
        }
    }
}
