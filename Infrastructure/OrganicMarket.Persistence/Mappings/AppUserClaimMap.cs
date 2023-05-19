using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganicMarket.Domain.Entities.Identity;

namespace OrganicMarket.Persistence.Mappings;

public class AppUserClaimMap : IEntityTypeConfiguration<AppUserClaim>
{
    public void Configure(EntityTypeBuilder<AppUserClaim> builder)
    {
        builder.HasKey(uc => uc.Id);
        builder.ToTable("AspNetUserClaims");
    }
}
