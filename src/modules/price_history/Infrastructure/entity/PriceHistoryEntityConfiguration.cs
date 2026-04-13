using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class PriceHistoryEntityConfiguration : IEntityTypeConfiguration<PriceHistoryEntity>
{
    public void Configure(EntityTypeBuilder<PriceHistoryEntity> builder)
    {
        builder.ToTable("price_history");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.OldPrice).HasPrecision(18, 2);
        builder.Property(x => x.NewPrice).HasPrecision(18, 2);
        builder.Property(x => x.ChangedAt).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.Property(x => x.ReasonChange).HasColumnType("longtext");
        builder.HasOne(x => x.Price)
            .WithMany()
            .HasForeignKey(x => x.PriceId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

