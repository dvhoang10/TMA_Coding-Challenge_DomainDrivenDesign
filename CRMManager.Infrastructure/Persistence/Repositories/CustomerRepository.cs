using CRMManager.Domain.Aggregates.CustomerAggregate.Repositories;
using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using CRMManager.Domain.Aggregates.CustomerAggregate;
using Microsoft.EntityFrameworkCore;

namespace CRMManager.Infrastructure.Persistence.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CRMManagerContext _context;

        public CustomerRepository(CRMManagerContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Customer entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _context.Customers.AsNoTracking().ToListAsync();
        }
    }
}
