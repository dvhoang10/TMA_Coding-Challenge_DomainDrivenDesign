using CRMManager.Application.Features.Customers.Dtos;
using MediatR;

namespace CRMManager.Application.Features.Customers.Commands
{
    public record CreateCustomerCommand
    (
        string Name,
        string TaxNumber,
        string Street
    ) : IRequest<CustomerDto>;
}
