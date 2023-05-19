using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganicMarket.Domain.Entities;

namespace OrganicMarket.Persistence.Mappings;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(new Product{
            Name = "Taze Fasulye",
            Description = "Mevsiminde Adananın bahçelerinden toplanmış fasulye",
            Price = 50,
            SalesUnit = Domain.Enums.SalesUnits.Kg,
            FavoriteCount = 0,
            ViewCount = 0,
            CategoryId = Guid.Parse("0bd7b92f-d7bf-4dce-91c3-ac17f3b1b345"),
            CreatedDate = DateTime.Now,
            CreatedBy = "Süper Admin",
            ImageId = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214"),
            SupplierId = Guid.Parse("d7a9c01c-ffaf-49c5-86b3-f2eda4b970b5"),
            Id = Guid.Parse("6aab099d-e302-4a07-8cf8-cb883a497465")
        },
        new Product{
            Name = "Kırmızı Biber",
            Description = "Mevsiminde Adananın bahçelerinden toplanmış fasulye",
            Price = 50,
            SalesUnit = Domain.Enums.SalesUnits.Kg,
            FavoriteCount = 0,
            ViewCount = 0,
            CategoryId = Guid.Parse("0bd7b92f-d7bf-4dce-91c3-ac17f3b1b345"),
            CreatedDate = DateTime.Now,
            CreatedBy = "Süper Admin",
            ImageId = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214"),
            SupplierId = Guid.Parse("25783bd4-8e59-49bb-a10e-3b7c2ada573b"),
            Id = Guid.Parse("013e4f26-f5a1-4c56-8f9a-3d77c89bbcc4")
        });
    }
}
