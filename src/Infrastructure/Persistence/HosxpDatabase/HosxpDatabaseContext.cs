using Microsoft.EntityFrameworkCore;
using BigLion.Application.Common.Interfaces;

namespace BigLion.Infrastructure.Persistence.HosxpDatabase;

public partial class HosxpDatabaseContext : DbContext, IHosxpDatabaseContext
{
    public HosxpDatabaseContext()
    {
    }

    public HosxpDatabaseContext(DbContextOptions<HosxpDatabaseContext> options)
        : base(options)
    {
    }

    //public virtual DbSet<SuthQueue> SuthQueues { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        return base.SaveChangesAsync(cancellationToken);
    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //   {
    //       modelBuilder
    //           .HasPostgresExtension("dblink")
    //           .HasPostgresExtension("hstore")
    //           .HasPostgresExtension("pgcrypto")
    //           .HasPostgresExtension("tablefunc")
    //           .HasPostgresExtension("uuid-ossp");

    //       modelBuilder.Entity<SuthQueue>(entity =>
    //       {
    //           entity.HasKey(e => e.Id).HasName("suth_queue_pkey");

    //           entity.ToTable("suth_queue");

    //           entity.Property(e => e.Id).HasColumnName("id");
    //           entity.Property(e => e.Location)
    //               .HasMaxLength(255)
    //               .HasColumnName("location");
    //           entity.Property(e => e.Queue)
    //               .HasMaxLength(10)
    //               .HasColumnName("queue");
    //           entity.Property(e => e.Vn)
    //               .HasMaxLength(20)
    //               .HasColumnName("vn");

    //		entity.Property(e => e.Depcode)
    //			.HasMaxLength(16)
    //			.HasColumnName("depcode");
    //	});

    //       OnModelCreatingPartial(modelBuilder);
    //   }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
