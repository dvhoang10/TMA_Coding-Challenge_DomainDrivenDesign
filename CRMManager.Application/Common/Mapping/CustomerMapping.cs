using CRMManager.Application.Features.Customers.Commands;
using CRMManager.Application.Features.Customers.Dtos;
using CRMManager.Application.Features.Customers.Queries;
using CRMManager.Domain.Aggregates.CustomerAggregate;
using Mapster;

namespace CRMManager.Application.Common.Mapping
{
    public class CustomerMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Customer, CustomerDto>().
                 Map(dest => dest.Id, src => src.Id.Value);
            config.NewConfig<int, GetCustomerByIdQuery>().
               MapWith(src => new GetCustomerByIdQuery(src));
            config.NewConfig<int, DeleteCustomerCommand>().
               MapWith(src => new DeleteCustomerCommand(src));
        }
    }
}
