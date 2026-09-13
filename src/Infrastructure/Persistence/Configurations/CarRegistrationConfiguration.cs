using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BigLion.Domain.Entities;

namespace BigLion.Infrastructure.Persistence.Configurations;

public class CarRegistrationConfiguration : IEntityTypeConfiguration<CustomerCar>
{
    public void Configure(EntityTypeBuilder<CustomerCar> builder)
    {

        builder.HasKey(x => x.Id);
        builder.Property(x => x.CarNumber).HasMaxLength(50);
    }
}
