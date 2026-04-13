using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class TripStatesHistoryEntityConfiguration : IEntityTypeConfiguration<TripStatesHistoryEntity>
{
    public void Configure(EntityTypeBuilder<TripStatesHistoryEntity> builder)
    {
        builder.ToTable("trip_states_history");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.StatusName).HasMaxLength(50);
        builder.Property(x => x.LocationPoint).HasColumnType("point");
        builder.Property(x => x.CreatedAt).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.HasOne(x => x.Trip)
            .WithMany()
            .HasForeignKey(x => x.TripId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

