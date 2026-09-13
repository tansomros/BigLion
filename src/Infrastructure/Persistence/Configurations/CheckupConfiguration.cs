using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BigLion.Domain.Entities;

namespace BigLion.Infrastructure.Persistence.Configurations;
public class CheckupConfiguration : IEntityTypeConfiguration<Checkup>
{
    public void Configure(EntityTypeBuilder<Checkup> builder)
    {
        builder
            .HasKey(x => x.Id);

        builder
            .HasIndex(x => x.CheckupVisitId);

        builder
            .Property(e => e.PhysicalExaminationById)
            .IsRequired(false);

        builder
            .Property(e => e.ConclusionById)
            .IsRequired(false);

        builder.Property(r => r.FinalReport).HasColumnType("jsonb");

        builder.Property(r => r.LabOrder).IsRequired(true).HasColumnType("jsonb");
        builder.Property(r => r.XrayOrder).IsRequired(true).HasColumnType("jsonb");
        builder.Property(r => r.ServiceOrder).IsRequired(true).HasColumnType("jsonb");

        //builder
        //    .HasMany(e => e.Provinces)
        //    .WithOne(p => p.Checkup)
        //    .HasForeignKey(e => e.Id)
        //    .HasPrincipalKey(p => p.Id)
        //    .OnDelete(DeleteBehavior.Restrict);
    }
}
