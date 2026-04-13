using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class TripEntityConfiguration : IEntityTypeConfiguration<TripEntity>
{
    public void Configure(EntityTypeBuilder<TripEntity> builder)
    {
        builder.ToTable("trips");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FinalPrice).HasPrecision(18, 2);
        builder.Property(x => x.TrackingNumber).HasMaxLength(100);
        builder.Property(x => x.StartTime).HasColumnType("datetime(6)");
        builder.Property(x => x.EndTime).HasColumnType("datetime(6)");
        builder.Property(x => x.TripStateId);
        builder.HasOne(x => x.Lead)
            .WithMany()
            .HasForeignKey(x => x.LeadId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

