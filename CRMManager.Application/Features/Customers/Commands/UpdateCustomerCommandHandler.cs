using CRMManager.Application.Features.Customers.Dtos;
using CRMManager.Domain.Aggregates.CustomerAggregate.Repositories;
using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using MapsterMapper;
using MediatR;

namespace CRMManager.Application.Features.Customers.Commands
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public UpdateCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<CustomerDto?> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(CustomerId.Create(request.Id));

            if (customer == null) return null;

            customer.SetName(request.Name);
            customer.SetStreet(request.Street);
            customer.SetTaxNumber(request.TaxNumber);
            await _customerRepository.UpdateAsync(customer);

            return _mapper.Map<CustomerDto>(customer);
        }
    }
}
