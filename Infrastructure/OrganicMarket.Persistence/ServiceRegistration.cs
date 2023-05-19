using Microsoft.Extensions.DependencyInjection;
using OrganicMarket.Application.UOF;
using OrganicMarket.Persistence.Contexts;
using OrganicMarket.Persistence.UOF;

namespace OrganicMarket.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<OrganicMarketDbContext>();

        //services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
        services.AddScoped<IUnitOfWork,UnitOfWork>();
    }
}
