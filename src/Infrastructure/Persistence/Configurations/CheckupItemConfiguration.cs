using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BigLion.Domain.Entities;

namespace BigLion.Infrastructure.Persistence.Configurations
{
   public class CheckupItemConfiguration : IEntityTypeConfiguration<CheckupItem>
    {
        public void Configure(EntityTypeBuilder<CheckupItem> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
            .HasIndex(x => x.Code);
        }

    }
}
