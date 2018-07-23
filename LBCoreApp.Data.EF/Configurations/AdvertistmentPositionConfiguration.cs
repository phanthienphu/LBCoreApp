using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using LBCoreApp.Data.EF.Extensions;
using LBCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LBCoreApp.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50).IsRequired()
                 .HasColumnType("varchar(50)"); 
            // etc.
        }
    }
}
