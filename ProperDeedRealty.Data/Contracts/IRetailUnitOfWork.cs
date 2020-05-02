using System;
using System.Collections.Generic;
using System.Text;

namespace ProperDeedRealty.Data.Contracts
{
    public interface IRetailUnitOfWork
    {
        void Commit();
        IBankdraftSetupRepository bankdraftSetup { get; }
        IAPIStubRepository API { get; }
        ITransferChargesRepository transferCharges { get; }
        IGrantReversalPrivilegeRepository grantreversal { get; }
        IRetailOperationRepository retailOperation { get; }
        IReversalSetupRepository reversalSetup { get; }
        IOperationTypeRepository operationType { get; }
        ITillFunctionRepository tillFunction { get; }
        ITellerLimitRepository tellerLimit { get; }
        ITillLimitRepository tillLimit { get; }
        ITellerSetupRepository tellerSetup { get; }
        ITellerloginRepository tellerlogin { get; }
        ITillDefinitionRepository tillDefinition { get; }
        ITillMappingRepository tillMapping { get; }
        ITillTypeRepository tillType { get; }
        ITellerCloseLimitSetupRepository tellerCloseLimitSetup { get; }
        ITillLimitSetupRepository tillLimitSetup { get; }
        IChequeBookTypeRepository ChequeTypes { get; }
        IChequeBookDetailRepository ChequeDetails { get; }
        IChequeLeavesDetailRepository ChequeLeaves { get; }
        IInwardBankChequeRepository InwardCheques { get; }
        IOutwardBankChequeRepository OutwardCheques { get; }
        IChequeChargesRepository ChequeCharges { get; }
        ICOTSetupRepository COT { get; }
        IStampChargeRepository StampDuty { get; }
        IBankingoperationtypeRepository BankOptType { get; }

        //Added by Babs
        ITransactionRepository Transaction { get; }
        ITellerPostingRepository TransactionOperations { get; }
        IChartofAccountRepository Chart { get; }
        IStaffInformaionRepository StaffInformation { get; }
        ISingleFundTransferRepository SingleFundTransfer { get; }
        IFinanceCounterpartyTransactionRepository FinCounterParty { get; }


    }
}
