using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BigLion.Domain.Entities;

namespace BigLion.Infrastructure.Persistence.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(100);
    }
}
