﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Models;

namespace ProperDeedRealty.Data.Contracts
{
    public interface ITransferChargesRepository : IRepository<TblTransfercharge>
    {
        IQueryable<TblTransfercharge> GetActive();
    }
}
