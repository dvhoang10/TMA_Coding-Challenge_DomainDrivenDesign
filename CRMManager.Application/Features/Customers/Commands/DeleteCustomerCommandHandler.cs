using CRMManager.Application.Features.Customers.Dtos;
using CRMManager.Domain.Aggregates.CustomerAggregate.Repositories;
using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using MapsterMapper;
using MediatR;

namespace CRMManager.Application.Features.Customers.Commands
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public DeleteCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<CustomerDto?> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.DeleteAsync(CustomerId.Create(request.Id));

            if (customer == null) return null;

            return _mapper.Map<CustomerDto>(customer);
        }
    }
}
