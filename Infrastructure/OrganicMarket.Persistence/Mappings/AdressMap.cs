using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganicMarket.Domain.Entities;

namespace OrganicMarket.Persistence.Mappings;

public class AdressMap : IEntityTypeConfiguration<Adress>
{
    public void Configure(EntityTypeBuilder<Adress> builder)
    {
        builder.HasData(new Adress{
            Title = "Ev Adresi",
            City = "Sakarya",
            Neighbourhood = "Küpçüler",
            District = "Erenler",
            PostCode = 54100,
            Id = Guid.NewGuid(),
            UserId = Guid.Parse("4BB43339-1C0F-4630-9D1A-DD579ECD0428"),
            CreatedBy = "Süper Admin",
            CreatedDate = DateTime.Now,
        },
        new Adress{
            Title = "2. Ev Adresi",
            City = "İstanbul",
            Neighbourhood = "Bağcılar",
            District = "Sultan",
            PostCode = 34250,
            Id = Guid.NewGuid(),
            UserId = Guid.Parse("4BB43339-1C0F-4630-9D1A-DD579ECD0428"),
            CreatedBy = "Süper Admin",
            CreatedDate = DateTime.Now,
        },
        new Adress{
            Title = "Köy Evi Adresi",
            City = "Konya",
            Neighbourhood = "Bozkır",
            District = "Ayvalca",
            PostCode = 42630,
            Id = Guid.NewGuid(),
            UserId = Guid.Parse("4BB43339-1C0F-4630-9D1A-DD579ECD0428"),
            CreatedBy = "Süper Admin",
            CreatedDate = DateTime.Now,
        }
        );
    }
}
