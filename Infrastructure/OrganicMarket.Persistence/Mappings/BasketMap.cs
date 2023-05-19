using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganicMarket.Domain.Entities;

namespace OrganicMarket.Persistence.Mappings;

public class BasketMap : IEntityTypeConfiguration<Basket>
{
    public void Configure(EntityTypeBuilder<Basket> builder)
    {
        //95a6074a-144a-4d19-ab48-27de1e157ff0
        builder.HasData(new Basket{
            BeingOrder = false,
            ProductCount = 0,
            UserId = Guid.Parse("4BB43339-1C0F-4630-9D1A-DD579ECD0428"),
            CreatedBy = "Süper Admin",
            CreatedDate = DateTime.Now,
            Id = Guid.Parse("2335fd49-d0e3-4ee6-8f4e-2d4386172d3a")
        });
    }
}
