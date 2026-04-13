using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class CompanyVehicleEntityConfiguration : IEntityTypeConfiguration<CompanyVehicleEntity>
{
    public void Configure(EntityTypeBuilder<CompanyVehicleEntity> builder)
    {
        builder.ToTable("company_vehicles");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.IsActive).HasDefaultValue(true);
        builder.HasOne(x => x.Company)
            .WithMany()
            .HasForeignKey(x => x.CompanyId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.Vehicle)
            .WithMany()
            .HasForeignKey(x => x.VehicleId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
