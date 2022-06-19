namespace Kidsffw.Contracts.Interfaces;

public interface IRepository<T> where T : class
{
    IAsyncEnumerable<T> GetAllAsync();
    Task<T> GetByPartitionKeyAsync(string partitionKey);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}