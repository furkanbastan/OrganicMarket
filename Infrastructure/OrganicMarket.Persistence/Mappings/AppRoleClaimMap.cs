using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganicMarket.Domain.Entities.Identity;

namespace OrganicMarket.Persistence.Mappings;

public class AppRoleClaimMap : IEntityTypeConfiguration<AppRoleClaim>
{
    public void Configure(EntityTypeBuilder<AppRoleClaim> builder)
    {
        builder.HasKey(rc => rc.Id);
        builder.ToTable("AspNetRoleClaims");
    }
}
