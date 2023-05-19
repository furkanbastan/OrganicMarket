using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganicMarket.Domain.Entities.Identity;

namespace OrganicMarket.Persistence.Mappings;

public class AppUserTokenMap : IEntityTypeConfiguration<AppUserToken>
{
    public void Configure(EntityTypeBuilder<AppUserToken> builder)
    {
        builder.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });

        //Bunların boyutları sınırlandırılmalı !!
        builder.Property(t => t.LoginProvider);
        builder.Property(t => t.Name);

        builder.ToTable("AspNetUserTokens");
    }
}
