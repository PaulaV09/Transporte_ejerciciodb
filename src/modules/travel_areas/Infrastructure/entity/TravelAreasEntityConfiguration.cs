using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class TravelAreaEntityConfiguration : IEntityTypeConfiguration<TravelAreaEntity>
{
    public void Configure(EntityTypeBuilder<TravelAreaEntity> builder)
    {
        builder.ToTable("travel_areas");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ArrivalDate).HasColumnType("datetime(6)");
        builder.Property(x => x.DepartureDate).HasColumnType("datetime(6)");
        builder.HasOne(x => x.Trip)
            .WithMany()
            .HasForeignKey(x => x.TripId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.City)
            .WithMany()
            .HasForeignKey(x => x.CityId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
