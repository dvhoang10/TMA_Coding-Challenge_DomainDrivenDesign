using CRMManager.Application.Features.Customers.Dtos;
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
        }
    }
}
