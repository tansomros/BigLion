using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BigLion.Domain.Entities;

namespace BigLion.Infrastructure.Persistence.Configurations;

public class RunningConfiguration : IEntityTypeConfiguration<Running>
{
    public void Configure(EntityTypeBuilder<Running> builder)
    {

        builder.HasKey(x => x.Code);
        builder.Property(x => x.Code).HasMaxLength(10);
    }
}
