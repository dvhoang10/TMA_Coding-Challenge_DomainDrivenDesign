using CRMManager.Domain.Aggregates.CustomerAggregate;
using MediatR;

namespace CRMManager.Application.Features.Customers.Queries
{
    public record ListAllCustomersQuery() : IRequest<List<Customer>>;
}
