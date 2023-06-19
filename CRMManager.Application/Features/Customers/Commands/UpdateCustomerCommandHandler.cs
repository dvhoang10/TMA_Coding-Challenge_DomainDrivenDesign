using CRMManager.Domain.Aggregates.CustomerAggregate.Repositories;
using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using MediatR;

namespace CRMManager.Application.Features.Customers.Commands
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;

        public UpdateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(CustomerId.Create(request.Id));

            if (customer != null)
            {
                customer.SetName(request.Name);
                customer.SetStreet(request.Street);
                customer.SetTaxNumber(request.TaxNumber);
                await _customerRepository.UpdateAsync(customer);
            }
        }
    }
}
