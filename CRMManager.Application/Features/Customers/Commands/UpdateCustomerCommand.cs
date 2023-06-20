using CRMManager.Application.Features.Customers.Dtos;
using MediatR;

namespace CRMManager.Application.Features.Customers.Commands
{
    public record UpdateCustomerCommand
    (
        int Id,
        string Name,
        string TaxNumber,
        string Street
    ) : IRequest<CustomerDto>;
}
