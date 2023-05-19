using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganicMarket.Domain.Entities;

namespace OrganicMarket.Persistence.Mappings;

public class ImageMap : IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.HasData(new Image{
            CreatedBy = "Süper Admin",
            CreatedDate = DateTime.Now,
            FileName = "test1",
            FileType = "JPG",
            Id = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214")
        },
        new Image{
            CreatedBy = "Süper Admin",
            CreatedDate = DateTime.Now,
            FileName = "test2",
            FileType = "PNG",
            Id = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA")
        });
    }
}
