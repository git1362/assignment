using SomeonesToDoListApp.Domain.Aggregates;
using SomeonesToDoListApp.Domain.Common;
using SomeonesToDoListApp.Domain.Interfaces;
using SomonesToDoListApp.Services.ToDos.Dtos;

namespace SomonesToDoListApp.Services.Contracts
{
    public interface IAsyncRepository<T> where T : EntityBase, IAggregateRoot
    {
        Task<T?> GetAsync(int id);
        Task<IReadOnlyList<T>> GetListAsync();
        Task<int> CreateAsync(T entity);
        Task UpdateAsync(T entity);
    }
}
