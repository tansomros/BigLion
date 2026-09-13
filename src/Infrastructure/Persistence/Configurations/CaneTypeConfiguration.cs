using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BigLion.Domain.Entities;

namespace BigLion.Infrastructure.Persistence.Configurations;

public class CaneTypeConfiguration : IEntityTypeConfiguration<CaneType>
{
    public void Configure(EntityTypeBuilder<CaneType> builder)
    {

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Description).HasMaxLength(100);
        builder.Property(x => x.Remark).HasMaxLength(100);
    }
}
