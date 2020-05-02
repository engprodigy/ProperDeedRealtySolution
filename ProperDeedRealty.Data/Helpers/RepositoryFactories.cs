using System;
using System.Collections.Generic;
using ProperDeedRealty.Data.Models;
using ProperDeedRealty.Data.Contracts;
using ProperDeedRealty.Data.Repository;

namespace ProperDeedRealty.Data.Helpers
{
    /// <summary>
    /// A maker of Code Camper Repositories.
    /// </summary>
    /// <remarks>
    /// An instance of this class contains repository factory functions for different types.
    /// Each factory function takes an EF <see cref="DbContext"/> and returns
    /// a repository bound to that DbContext.
    /// <para>
    /// Designed to be a "Singleton", configured at web application start with
    /// all of the factory functions needed to create any type of repository.
    /// Should be thread-safe to use because it is configured at app start,
    /// before any request for a factory, and should be immutable thereafter.
    /// </para>
    /// </remarks>
    public class RepositoryFactories
    {
        /// <summary>
        /// Return the runtime Code Camper repository factory functions,
        /// each one is a factory for a repository of a particular type.
        /// </summary>
        /// <remarks>
        /// MODIFY THIS METHOD TO ADD CUSTOM CODE CAMPER FACTORY FUNCTIONS
        /// </remarks>
        private IDictionary<Type, Func<TheCoreBankingRetailContext, object>> GetFactories()
        {
            return new Dictionary<Type, Func<TheCoreBankingRetailContext, object>>
            {
                {typeof(IBankdraftSetupRepository), dbContext => new BankDraftSetupRepository(dbContext)},
                {typeof(IAPIStubRepository), dbContext => new APIStubRepository(dbContext)},
                {typeof(ITransferChargesRepository), dbContext => new TransferChargesRepository(dbContext) },
                {typeof(IGrantReversalPrivilegeRepository),dbContext => new GrantReversalPrivilegeRepository(dbContext) },
                {typeof(IRetailOperationRepository), dbContext => new RetailOperationRepository(dbContext)},
                {typeof(IReversalSetupRepository), dbContext => new ReversalSetupRepository(dbContext)},
                {typeof(ITellerCloseLimitSetupRepository), dbContext => new TellerCloseLimitSetupRepository(dbContext)},
                {typeof(ITillLimitSetupRepository), dbContext => new TillLimitSetupRepository(dbContext)},
                {typeof(IChequeBookTypeRepository), dbContext => new ChequeBookTypeRepository(dbContext)},
                {typeof(IInwardBankChequeRepository), dbContext => new InwardBankChequeRepository(dbContext)},
                {typeof(IChequeBookDetailRepository), dbContext => new ChequeBookDetailRepository(dbContext)},
                {typeof(IChequeLeavesDetailRepository), dbContext => new ChequeLeavesDetailRepository(dbContext)},
                {typeof(ITillDefinitionRepository), dbContext => new TillDefinitionRepository(dbContext)},
                {typeof(ITillFunctionRepository), dbContext => new TillFunctionRepository(dbContext)},
                {typeof(ITillTypeRepository), dbContext => new TillTypeRepository(dbContext)},
                {typeof(ITillMappingRepository), dbContext => new TillMappingRepository(dbContext)},
                {typeof(ITillLimitRepository), dbContext => new TillLimitRepository(dbContext)},
                {typeof(ITellerloginRepository), dbContext => new TellerloginRepository(dbContext)},
                {typeof(ITellerSetupRepository), dbContext => new TellerSetupRepository(dbContext)},
                {typeof(ITellerLimitRepository), dbContext => new TellerLimitRepository(dbContext)},
                {typeof(IOperationTypeRepository), dbContext => new OperationTypeRepository(dbContext)},
                {typeof(IChequeChargesRepository), dbContext => new ChequeChargesRepository(dbContext)},
                {typeof(ICOTSetupRepository), dbContext => new COTSetupRepository(dbContext)},
                {typeof(IStampChargeRepository), dbContext => new StampChargeRepository(dbContext)},
                {typeof(IOutwardBankChequeRepository), dbContext => new OutwardBankChequeRepository(dbContext)},
                {typeof(IBankingoperationtypeRepository), dbContext => new BankingoperationtypeRepository(dbContext)},

                //Added by Babs
                  {typeof(ITellerPostingRepository), dbContext => new TellerPostingRepository(dbContext)},
                  {typeof(ITransactionRepository), dbContext => new TransactionRepository(dbContext)},
                  {typeof(IChartofAccountRepository), dbContext => new ChartofAccountRepository(dbContext)},
                  {typeof(IStaffInformaionRepository), dbContext => new StaffInformaionRepository(dbContext)},
                  {typeof(ISingleFundTransferRepository), dbContext => new SingleFundTransferRepository(dbContext)},
                   {typeof(IFinanceCounterpartyTransactionRepository), dbContext => new FinanceCounterpartyTransactionRepository(dbContext)},




            };
        }

        /// <summary>
        /// Constructor that initializes with runtime Code Camper repository factories
        /// </summary>
        public RepositoryFactories()
        {
            _repositoryFactories = GetFactories();
        }

        /// <summary>
        /// Constructor that initializes with an arbitrary collection of factories
        /// </summary>
        /// <param name="factories">
        /// The repository factory functions for this instance. 
        /// </param>
        /// <remarks>
        /// This ctor is primarily useful for testing this class
        /// </remarks>
        public RepositoryFactories(IDictionary<Type, Func<TheCoreBankingRetailContext, object>> factories)
        {
            _repositoryFactories = factories;
        }

        /// <summary>
        /// Get the repository factory function for the type.
        /// </summary>
        /// <typeparam name="T">Type serving as the repository factory lookup key.</typeparam>
        /// <returns>The repository function if found, else null.</returns>
        /// <remarks>
        /// The type parameter, T, is typically the repository type 
        /// but could be any type (e.g., an entity type)
        /// </remarks>
        public Func<TheCoreBankingRetailContext, object> GetRepositoryFactory<T>()
        {

            Func<TheCoreBankingRetailContext, object> factory;
            _repositoryFactories.TryGetValue(typeof(T), out factory);
            return factory;
        }

        /// <summary>
        /// Get the factory for <see cref="IRepository{T}"/> where T is an entity type.
        /// </summary>
        /// <typeparam name="T">The root type of the repository, typically an entity type.</typeparam>
        /// <returns>
        /// A factory that creates the <see cref="IRepository{T}"/>, given an EF <see cref="DbContext"/>.
        /// </returns>
        /// <remarks>
        /// Looks first for a custom factory in <see cref="_repositoryFactories"/>.
        /// If not, falls back to the <see cref="DefaultEntityRepositoryFactory{T}"/>.
        /// You can substitute an alternative factory for the default one by adding
        /// a repository factory for type "T" to <see cref="_repositoryFactories"/>.
        /// </remarks>
        public Func<TheCoreBankingRetailContext, object> GetRepositoryFactoryForEntityType<T>() where T : class
        {
            return GetRepositoryFactory<T>() ?? DefaultEntityRepositoryFactory<T>();
        }

        /// <summary>
        /// Default factory for a <see cref="IRepository{T}"/> where T is an entity.
        /// </summary>
        /// <typeparam name="T">Type of the repository's root entity</typeparam>
        protected virtual Func<TheCoreBankingRetailContext, object> DefaultEntityRepositoryFactory<T>() where T : class
        {
            return dbContext => new EFRepository<T>(dbContext);
        }

        /// <summary>
        /// Get the dictionary of repository factory functions.
        /// </summary>
        /// <remarks>
        /// A dictionary key is a System.Type, typically a repository type.
        /// A value is a repository factory function
        /// that takes a <see cref="DbContext"/> argument and returns
        /// a repository object. Caller must know how to cast it.
        /// </remarks>
        private readonly IDictionary<Type, Func<TheCoreBankingRetailContext, object>> _repositoryFactories;

    }
}
