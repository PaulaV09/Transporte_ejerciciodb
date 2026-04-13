using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class VehicleStateEntityConfiguration : IEntityTypeConfiguration<VehicleStateEntity>
{
    public void Configure(EntityTypeBuilder<VehicleStateEntity> builder)
    {
        builder.ToTable("vehicles_states");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
        builder.Property(x => x.Description).HasColumnType("longtext");
    }
}