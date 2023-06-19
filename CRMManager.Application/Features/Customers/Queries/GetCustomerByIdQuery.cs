using CRMManager.Application.Features.Customers.Dtos;
using MediatR;

namespace CRMManager.Application.Features.Customers.Queries
{
    public record GetCustomerByIdQuery(int Id) : IRequest<CustomerDto>;
}
