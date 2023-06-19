using CRMManager.Domain.Aggregates.CustomerAggregate.Repositories;
using CRMManager.Infrastructure.Persistence;
using CRMManager.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CRMManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<CRMManagerContext>
                (options => options.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=NZWalksDb;Trusted_Connection=True;TrustServerCertificate=True"));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            return services;
        }
    }
}
