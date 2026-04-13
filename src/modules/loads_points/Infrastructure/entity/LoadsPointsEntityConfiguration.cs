using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class LoadPointEntityConfiguration : IEntityTypeConfiguration<LoadPointEntity>
{
    public void Configure(EntityTypeBuilder<LoadPointEntity> builder)
    {
        builder.ToTable("load_points");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Address).IsRequired().HasColumnType("longtext");
        builder.Property(x => x.LocationPoint).HasColumnType("point");
        builder.Property(x => x.PointType).HasMaxLength(20);
        builder.Property(x => x.ContactPerson).HasMaxLength(100);
        builder.Property(x => x.ContactPhone).HasMaxLength(20);
        builder.HasOne(x => x.Lead)
            .WithMany()
            .HasForeignKey(x => x.LeadId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

