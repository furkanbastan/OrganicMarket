using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganicMarket.Domain.Entities.Identity;

namespace OrganicMarket.Persistence.Mappings;

public class AppUserLoginMap : IEntityTypeConfiguration<AppUserLogin>
{
    public void Configure(EntityTypeBuilder<AppUserLogin> builder)
    {
        builder.HasKey(l => new { l.LoginProvider, l.ProviderKey });

        builder.Property(l => l.LoginProvider).HasMaxLength(128);
        builder.Property(l => l.ProviderKey).HasMaxLength(128);

        builder.ToTable("AspNetUserLogins");
    }
}
