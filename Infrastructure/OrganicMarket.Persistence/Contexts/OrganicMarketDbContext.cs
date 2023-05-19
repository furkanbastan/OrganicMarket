using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OrganicMarket.Domain.Entities;
using OrganicMarket.Domain.Entities.Identity;

namespace OrganicMarket.Persistence.Contexts;

public class OrganicMarketDbContext : IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
{
    public OrganicMarketDbContext(DbContextOptions<OrganicMarketDbContext> options) : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = C:\\Users\\bbast\\OneDrive\\Masaüstü\\OrganicMarket\\Infrastructure\\OrganicMarket.Persistence\\DB\\OrganicMarket.db;");
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Adress> Adresses { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<BasketProduct> BasketProducts { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }
}

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<OrganicMarketDbContext>
{
    public OrganicMarketDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<OrganicMarketDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseSqlite("Data Source = C:\\Users\\bbast\\OneDrive\\Masaüstü\\OrganicMarket\\Infrastructure\\OrganicMarket.Persistence\\DB\\OrganicMarket.db;");
        return new(dbContextOptionsBuilder.Options);
    }
}
