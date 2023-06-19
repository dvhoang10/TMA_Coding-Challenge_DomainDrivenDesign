using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using CRMManager.Domain.Common.Interfaces;

namespace CRMManager.Domain.Aggregates.CustomerAggregate.Repositories
{
    public interface ICustomerRepository : IBaseRepository<Customer, CustomerId>
    {
    }
}
