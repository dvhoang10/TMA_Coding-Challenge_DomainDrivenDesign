namespace CRMManager.Domain.Common.Interfaces
{
    public interface IBaseRepository<T, TId> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task<T?> GetByIdAsync(TId id);
        Task UpdateAsync(T entity);
        Task DeleteAsync(TId id);
    }
}
