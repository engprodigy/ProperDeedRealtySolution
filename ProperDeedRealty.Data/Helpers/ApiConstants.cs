namespace ProperDeedRealty.Data.Helpers
{
    public class ApiConstants
    {
        public const string BaseApiUrl = "http://bankingplatform:8042/";
        // public const string BaseApiUrl = "http://localhost:2289/";
        public const string ChartOfAccountEndpoint = "Finances/Chart/ListChart";
        public const string CurrencyEndpoint = "finances/financesetup/listcurrency";
        public const string ProductEndpoint = "product/ProductMapping/listproduct";
        public const string UserEndpoint = "Administration/ListUsers";
        public const string CompanyEndpoint = "company/companysetup/listcompany";
        public const string BranchEndpoint = "company/companysetup/listbranch";
        public const string LoanBookingEndpoint = "credits/creditsetup/listloanlease";
        public const string CASAEndpoint = "Customer/Account/ListAccountNoMapDetails";
        public const string CurrentAccountEndpoint = "Customer/Account/ListCurrentAccounts";
        public const string ChequeAccountEndpoint = "Customer/Account/ListChequeAccounts";
        public const string CASAMandateEndpoint = "Customer/Account/GetMandatesByAccNo";
        public const string CASAMandateDocListEndpoint = "Customer/Account/LoadMandateFiles";
        public const string CASAMandateDocEndpoint = "Customer/Account/LoadMandateDocument";
        public const string StampDutyChargeEndpoint = "Retail/Setup/LoadStampDuty";
        public const string DepartmentEndpoint = "company/customersetup/listdepartment";
    }
}
