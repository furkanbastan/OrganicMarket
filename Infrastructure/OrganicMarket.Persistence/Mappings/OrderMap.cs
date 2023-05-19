using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganicMarket.Domain.Entities;

namespace OrganicMarket.Persistence.Mappings;

public class OrderMap : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasData(new Order{
            Completed = false,
            CreatedBy = "Süper Admin",
            CreatedDate = DateTime.Now,
            Id = Guid.Parse("91593468-0be9-4543-9045-b02f112b1d8e"),
            UserId = Guid.Parse("4BB43339-1C0F-4630-9D1A-DD579ECD0428")
        });
    }
}
