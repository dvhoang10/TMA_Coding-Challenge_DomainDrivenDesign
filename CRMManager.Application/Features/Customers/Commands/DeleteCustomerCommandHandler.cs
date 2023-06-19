using CRMManager.Domain.Aggregates.CustomerAggregate.Repositories;
using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using MediatR;

namespace CRMManager.Application.Features.Customers.Commands
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;
        public DeleteCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;

        }
        public async Task Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            await _customerRepository.DeleteAsync(CustomerId.Create(request.Id));
        }
    }
}
