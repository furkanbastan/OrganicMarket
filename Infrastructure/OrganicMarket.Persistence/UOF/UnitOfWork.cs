using OrganicMarket.Application.Repositories;
using OrganicMarket.Application.UOF;
using OrganicMarket.Domain.Entities.Common;
using OrganicMarket.Persistence.Contexts;
using OrganicMarket.Persistence.Repositories;

namespace OrganicMarket.Persistence.UOF;

public class UnitOfWork : IUnitOfWork
{
    private readonly OrganicMarketDbContext _dbContext;
    public UnitOfWork(OrganicMarketDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async ValueTask DisposeAsync()
    {
        await _dbContext.DisposeAsync();
    }
    public int Save()
    {
        return _dbContext.SaveChanges();
    }
    public async Task<int> SaveAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }
    public IRepository<T> GetRepository<T>() where T : class, IEntityBase, new()
    {
        return new Repository<T>(_dbContext);
    }
}
