using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;
public sealed class VehicleEntityConfiguration : IEntityTypeConfiguration<VehicleEntity>
{
    public void Configure(EntityTypeBuilder<VehicleEntity> builder)
    {
        builder.ToTable("vehicles");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Brand).HasMaxLength(50);
        builder.Property(x => x.Model).HasMaxLength(20);
        builder.Property(x => x.Plate).IsRequired().HasMaxLength(10);
        builder.HasIndex(x => x.Plate).IsUnique();
        builder.Property(x => x.Color).HasMaxLength(20);
        builder.Property(x => x.ChassisNumber).HasMaxLength(50);
        builder.HasOne(x => x.TypeVehicle)
            .WithMany()
            .HasForeignKey(x => x.TypeVehicleId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.VehicleState)
            .WithMany()
            .HasForeignKey(x => x.VehicleStateId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.Owner)
            .WithMany()
            .HasForeignKey(x => x.OwnerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
