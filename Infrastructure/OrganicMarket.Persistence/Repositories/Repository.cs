using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using OrganicMarket.Application.Repositories;
using OrganicMarket.Domain.Entities.Common;
using OrganicMarket.Persistence.Contexts;

namespace OrganicMarket.Persistence.Repositories;

public class Repository<T> : IRepository<T> where T : class, IEntityBase, new()
{
    private readonly OrganicMarketDbContext _dbContext;
    public Repository(OrganicMarketDbContext dbContext)
    {
        _dbContext = dbContext;
        Table = dbContext.Set<T>();
    }
    private DbSet<T> Table { get; }
    public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T,object>>[] includeProperties)
    {
        IQueryable<T> query = Table;

        if(predicate != null)
            query = query.Where(predicate);

        if(includeProperties.Any())
            foreach (var item in includeProperties)
                query = query.Include(item);

        return await query.ToListAsync();
    }

    public async Task<List<T>> GetAsync(Expression<Func<T, bool>> predicate , params Expression<Func<T,object>>[] includeProperties)
    {
        IQueryable<T> query = Table;

        query = query.Where(predicate);

        if(includeProperties.Any())
            foreach (var item in includeProperties)
                query = query.Include(item);

        return await query.ToListAsync();
    }

    public async Task AddAsync(T entity)
        => await Table.AddAsync(entity);

    public async Task AnyAsync(Expression<Func<T,bool>> predicate)
        => await Table.AnyAsync(predicate);

    public async Task<int> CountAsync(Expression<Func<T,bool>> predicate = null)
        => predicate != null ? await Table.CountAsync(predicate) : await Table.CountAsync();
    
    public async Task DeleteAsync(T entity)
        => await Task.Run(() => Table.Remove(entity));

    public async Task<T> GetByGuidAsync(Guid id)
        => await Table.FindAsync(id);

    public async Task UpdateAsync(T entity)
        => await Task.Run(() => Table.Update(entity));
}
