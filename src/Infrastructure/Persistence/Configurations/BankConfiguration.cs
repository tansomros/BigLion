using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BigLion.Domain.Entities;

namespace BigLion.Infrastructure.Persistence.Configurations;

public class BankConfiguration : IEntityTypeConfiguration<Bank>
{
    public void Configure(EntityTypeBuilder<Bank> builder)
    {

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Code).HasMaxLength(10);
        builder.Property(x => x.Name).HasMaxLength(100);
    }
}
