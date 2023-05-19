using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganicMarket.Domain.Entities;

namespace OrganicMarket.Persistence.Mappings;

public class BasketProductMap : IEntityTypeConfiguration<BasketProduct>
{
    public void Configure(EntityTypeBuilder<BasketProduct> builder)
    {
        builder.HasKey(bp => new {bp.BasketId, bp.ProductId});

        builder.HasData(
        new BasketProduct{
            BasketId = Guid.Parse("2335fd49-d0e3-4ee6-8f4e-2d4386172d3a"),
            ProductId = Guid.Parse("6aab099d-e302-4a07-8cf8-cb883a497465")
        },
        new BasketProduct{
            BasketId = Guid.Parse("2335fd49-d0e3-4ee6-8f4e-2d4386172d3a"),
            ProductId = Guid.Parse("013e4f26-f5a1-4c56-8f9a-3d77c89bbcc4")
        });
    }
}
