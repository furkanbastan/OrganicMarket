using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganicMarket.Domain.Entities;

namespace OrganicMarket.Persistence.Mappings;

public class SupplierMap : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder.HasData(
        new Supplier{
            Id = Guid.Parse("d7a9c01c-ffaf-49c5-86b3-f2eda4b970b5"),
            CreatedBy = "Süper Admin",
            CreatedDate = DateTime.Now,
            Description = "Adana da 1999 da kurulduk.",
            Name = "Doğan Gıda"
        },
        new Supplier{
            Id = Guid.Parse("25783bd4-8e59-49bb-a10e-3b7c2ada573b"),
            CreatedBy = "Süper Admin",
            CreatedDate = DateTime.Now,
            Description = "Sakarya da 1898 de kurulduk.",
            Name = "Baştan Gıda"
        });
    }
}
