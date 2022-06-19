namespace Kidsffw.Contracts.Interfaces;

public interface IRepository<T> where T : class
{
    IAsyncEnumerable<T> GetAllAsync();
    Task<T> GetByPartitionKeyAsync(string partitionKey);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}