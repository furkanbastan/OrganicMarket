using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganicMarket.Domain.Entities;

namespace OrganicMarket.Persistence.Mappings;

public class OrderProductMap : IEntityTypeConfiguration<OrderProduct>
{
    public void Configure(EntityTypeBuilder<OrderProduct> builder)
    {
        builder.HasKey(op => new {op.OrderId, op.ProductId});

        builder.HasData(
        new OrderProduct{
            OrderId = Guid.Parse("91593468-0be9-4543-9045-b02f112b1d8e"),
            ProductId = Guid.Parse("6aab099d-e302-4a07-8cf8-cb883a497465")
        },
        new OrderProduct{
            OrderId = Guid.Parse("91593468-0be9-4543-9045-b02f112b1d8e"),
            ProductId = Guid.Parse("013e4f26-f5a1-4c56-8f9a-3d77c89bbcc4")
        });
    }
}
