using System.Linq.Expressions;
using OrganicMarket.Domain.Entities.Common;

namespace OrganicMarket.Application.Repositories;

public interface IRepository<T> where T : class, IEntityBase, new()
{
    public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T,object>>[] includeProperties);

    public Task<List<T>> GetAsync(Expression<Func<T, bool>> predicate , params Expression<Func<T,object>>[] includeProperties);

    public Task AddAsync(T entity);

    public Task AnyAsync(Expression<Func<T,bool>> predicate);

    public Task<int> CountAsync(Expression<Func<T,bool>> predicate = null);
    
    public Task DeleteAsync(T entity);

    public Task<T> GetByGuidAsync(Guid id);

    public Task UpdateAsync(T entity);
}
