using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;
public sealed class DocumentVehicleEntityConfiguration : IEntityTypeConfiguration<DocumentVehicleEntity>
{
    public void Configure(EntityTypeBuilder<DocumentVehicleEntity> builder)
    {
        builder.ToTable("documents_vehicles");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.DocumentNumber).HasMaxLength(50);
        builder.Property(x => x.ImageUrl).HasColumnType("longtext");
        builder.HasOne(x => x.Vehicle)
            .WithMany()
            .HasForeignKey(x => x.VehicleId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.TypeDocument)
            .WithMany()
            .HasForeignKey(x => x.TypeDocumentId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.DocumentState)
            .WithMany()
            .HasForeignKey(x => x.DocumentStateId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
