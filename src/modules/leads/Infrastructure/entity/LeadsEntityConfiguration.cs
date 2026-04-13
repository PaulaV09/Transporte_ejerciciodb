using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class LeadEntityConfiguration : IEntityTypeConfiguration<LeadEntity>
{
    public void Configure(EntityTypeBuilder<LeadEntity> builder)
    {
        builder.ToTable("leads");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Weight).HasPrecision(10, 2);
        builder.Property(x => x.Volume).HasPrecision(10, 2);
        builder.Property(x => x.PickupDate).HasColumnType("datetime(6)");
        builder.Property(x => x.DeliveryDate).HasColumnType("datetime(6)");
        builder.Property(x => x.Budget).HasPrecision(18, 2);
        builder.Property(x => x.IsActive).HasDefaultValue(true);
        builder.Property(x => x.CreatedAt).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.HasOne(x => x.Customer)
            .WithMany()
            .HasForeignKey(x => x.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.TypeLoad)
            .WithMany()
            .HasForeignKey(x => x.TypeLoadId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.OriginCity)
            .WithMany()
            .HasForeignKey(x => x.OriginCityId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.DestinationCity)
            .WithMany()
            .HasForeignKey(x => x.DestinationCityId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

