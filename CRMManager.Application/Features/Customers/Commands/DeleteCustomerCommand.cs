using CRMManager.Application.Features.Customers.Dtos;
using MediatR;

namespace CRMManager.Application.Features.Customers.Commands
{
    public record DeleteCustomerCommand(int Id) : IRequest<CustomerDto>;
}
