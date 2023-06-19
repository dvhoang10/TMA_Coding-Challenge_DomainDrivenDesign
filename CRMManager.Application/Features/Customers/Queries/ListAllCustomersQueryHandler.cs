using CRMManager.Domain.Aggregates.CustomerAggregate;
using CRMManager.Domain.Aggregates.CustomerAggregate.Repositories;
using MediatR;

namespace CRMManager.Application.Features.Customers.Queries
{
    public class ListAllCustomersQueryHandler : IRequestHandler<ListAllCustomersQuery, List<Customer>>
    {
        private readonly ICustomerRepository _customerRepository;

        public ListAllCustomersQueryHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<List<Customer>> Handle(ListAllCustomersQuery request, CancellationToken cancellationToken)
        {
            return await _customerRepository.GetAllAsync();
        }
    }
}
