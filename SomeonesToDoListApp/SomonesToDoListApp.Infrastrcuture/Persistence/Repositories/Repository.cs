using Microsoft.EntityFrameworkCore;
using SomeonesToDoListApp.Domain.Aggregates;
using SomeonesToDoListApp.Domain.Common;
using SomeonesToDoListApp.Domain.Interfaces;
using SomonesToDoListApp.Services.Contracts;

namespace SomonesToDoListApp.Infrastrcuture.Persistence.Repositories
{
    public class Repository<T> : IAsyncRepository<T> where T : EntityBase, IAggregateRoot
    {
        private readonly SomeonesToDoListContext _dbContext;
        public Repository(SomeonesToDoListContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<int> CreateAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            var insertedId = await _dbContext.SaveChangesAsync();
            
            return insertedId > 0 ? entity.Id : 0;
         }

        public async Task<T?> GetAsync(int id)
        {
            return await _dbContext.Set<T>()
                          .AsNoTracking()
                          .SingleOrDefaultAsync(e => e.Id == id);
        }

        /// <summary>
        /// TODO: consider Pagination
        /// </summary>
        /// <returns></returns>
        public async Task<IReadOnlyList<T>> GetListAsync()
        {
            return await _dbContext.Set<T>()
                .AsNoTracking()
                .ToListAsync();
        }


        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
