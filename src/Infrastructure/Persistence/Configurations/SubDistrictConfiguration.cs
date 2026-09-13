using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BigLion.Domain.Entities;

namespace BigLion.Infrastructure.Persistence.Configurations;

public class SubDistrictConfiguration : IEntityTypeConfiguration<SubDistrict>
{
    public void Configure(EntityTypeBuilder<SubDistrict> builder)
    {
    }
}
