using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;
public sealed class DriverVehicleEntityConfiguration : IEntityTypeConfiguration<DriverVehicleEntity>
{
    public void Configure(EntityTypeBuilder<DriverVehicleEntity> builder)
    {
        builder.ToTable("drivers_vehicles");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.AssignedAt).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.Property(x => x.IsActive).HasDefaultValue(true);
        builder.HasOne(x => x.Driver)
            .WithMany()
            .HasForeignKey(x => x.DriverId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.Vehicle)
            .WithMany()
            .HasForeignKey(x => x.VehicleId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
