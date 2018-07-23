using LBCoreApp.Data.EF.Extensions;
using LBCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBCoreApp.Data.EF.Configurations
{
    class AnnouncementConfiguration : DbEntityConfiguration<Announcement>
    {
        public override void Configure(EntityTypeBuilder<Announcement> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(128).IsRequired()
                 .HasColumnType("varchar(128)");
            // etc.
        }
    }
}
