using System;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Helpers;
using ProperDeedRealty.Data.Models;
using ProperDeedRealty.Data.Repository;

namespace ProperDeedRealty.Data
{
    public class RetailUnitOfWork : IRetailUnitOfWork
    {
        private readonly TheCoreBankingRetailContext DbContext = new TheCoreBankingRetailContext();

        private IRepositoryProvider RepositoryProvider { get; }

        public RetailUnitOfWork(IRepositoryProvider repositoryProvider)
        {
            repositoryProvider.DbContext = DbContext;
            RepositoryProvider = repositoryProvider;
        }

        #region Repository definition

        public IBankdraftSetupRepository bankdraftSetup => GetEntityRepository<IBankdraftSetupRepository>();
        public IAPIStubRepository API => GetEntityRepository<IAPIStubRepository>();
        public ITransferChargesRepository transferCharges => GetEntityRepository<ITransferChargesRepository>();
        public IGrantReversalPrivilegeRepository grantreversal => GetEntityRepository<IGrantReversalPrivilegeRepository>();
        public IRetailOperationRepository retailOperation => GetEntityRepository<IRetailOperationRepository>();
        public IReversalSetupRepository reversalSetup => GetEntityRepository<IReversalSetupRepository>();
        public ITellerCloseLimitSetupRepository tellerCloseLimitSetup => GetEntityRepository<ITellerCloseLimitSetupRepository>();
        public ITillLimitSetupRepository tillLimitSetup => GetEntityRepository<ITillLimitSetupRepository>();
        public IChequeBookTypeRepository ChequeTypes => GetEntityRepository<IChequeBookTypeRepository>();
        public IChequeBookDetailRepository ChequeDetails => GetEntityRepository<IChequeBookDetailRepository>();
        public IChequeLeavesDetailRepository ChequeLeaves => GetEntityRepository<IChequeLeavesDetailRepository>();
        public IInwardBankChequeRepository InwardCheques => GetEntityRepository<IInwardBankChequeRepository>();
        public IOutwardBankChequeRepository OutwardCheques => GetEntityRepository<IOutwardBankChequeRepository>();
        public IChequeChargesRepository ChequeCharges => GetEntityRepository<IChequeChargesRepository>();
        public ICOTSetupRepository COT => GetEntityRepository<ICOTSetupRepository>();
        public IStampChargeRepository StampDuty => GetEntityRepository<IStampChargeRepository>();
        public IOperationTypeRepository operationType => GetEntityRepository<IOperationTypeRepository>();
        public ITillFunctionRepository tillFunction => GetEntityRepository<ITillFunctionRepository>();
        public ITellerLimitRepository tellerLimit => GetEntityRepository<ITellerLimitRepository>();
        public ITillLimitRepository tillLimit => GetEntityRepository<ITillLimitRepository>();
        public ITellerSetupRepository tellerSetup => GetEntityRepository<ITellerSetupRepository>();
        public ITellerloginRepository tellerlogin => GetEntityRepository<ITellerloginRepository>();
        public ITillDefinitionRepository tillDefinition => GetEntityRepository<ITillDefinitionRepository>();
        public ITillMappingRepository tillMapping => GetEntityRepository<ITillMappingRepository>();
        public ITillTypeRepository tillType => GetEntityRepository<ITillTypeRepository>();
        public IBankingoperationtypeRepository BankOptType => GetEntityRepository<IBankingoperationtypeRepository>();

        //Added by Babs
        public ITellerPostingRepository TransactionOperations => GetEntityRepository<ITellerPostingRepository>();
        public ITransactionRepository Transaction { get { return GetEntityRepository<ITransactionRepository>(); } }
        public IChartofAccountRepository Chart { get { return GetEntityRepository<IChartofAccountRepository>(); } }
        public IStaffInformaionRepository StaffInformation { get { return GetEntityRepository<IStaffInformaionRepository>(); } }
        public ISingleFundTransferRepository SingleFundTransfer { get { return GetEntityRepository<ISingleFundTransferRepository>(); } }
        public IFinanceCounterpartyTransactionRepository FinCounterParty { get { return GetEntityRepository<IFinanceCounterpartyTransactionRepository>(); } }



        #endregion

        public void Commit()
        {
            DbContext.SaveChanges();
        }

        private IRepository<T> GetStandardRepository<T>() where T : class
        {
            return RepositoryProvider.GetRepositoryForEntityType<T>();
        }

        private T GetEntityRepository<T>() where T : class
        {
            return RepositoryProvider.GetRepository<T>();
        }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();
                }
            }
        }

        #endregion
    }
}
