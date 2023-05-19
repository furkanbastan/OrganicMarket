using OrganicMarket.Application.Repositories;
using OrganicMarket.Domain.Entities.Common;

namespace OrganicMarket.Application.UOF;

public interface IUnitOfWork
{
    public ValueTask DisposeAsync();
    public int Save();
    public Task<int> SaveAsync();
    public IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();
}
