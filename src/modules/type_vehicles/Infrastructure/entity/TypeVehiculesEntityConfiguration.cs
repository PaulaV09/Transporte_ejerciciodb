using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;
public sealed class TypeVehicleEntityConfiguration : IEntityTypeConfiguration<TypeVehicleEntity>
{
    public void Configure(EntityTypeBuilder<TypeVehicleEntity> builder)
    {
        builder.ToTable("type_vehicles");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Description).HasColumnType("longtext");
    }
}
