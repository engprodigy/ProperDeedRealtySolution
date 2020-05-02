using System;

namespace ProperDeedRealty.Data.Contracts
{
    public interface IAPIStubRepository : IRepository<APIStubModel>
    {
    }

    public class APIStubModel
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public DateTime DateCreated { get; set; }
        public string AccountId { get; set; }
    }
}
