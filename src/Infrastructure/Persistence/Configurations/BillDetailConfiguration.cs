using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BigLion.Domain.Entities;

namespace BigLion.Infrastructure.Persistence.Configurations;

public class BillDetailConfiguration : IEntityTypeConfiguration<BillDetail>
{
    public void Configure(EntityTypeBuilder<BillDetail> builder)
    {

        builder.HasKey(x => x.Id);
        builder.Property(x => x.BillNumber).HasMaxLength(20);
        builder.Property(x => x.BillReference).HasMaxLength(20);
        builder.Property(x => x.CarNumber).HasMaxLength(20);
        builder.Property(x => x.BillFlag).HasMaxLength(1);
        builder.Property(x => x.Remark).HasMaxLength(100);
    }
}
