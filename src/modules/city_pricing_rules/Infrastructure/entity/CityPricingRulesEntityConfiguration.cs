using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class CityPricingRuleEntityConfiguration : IEntityTypeConfiguration<CityPricingRuleEntity>
{
    public void Configure(EntityTypeBuilder<CityPricingRuleEntity> builder)
    {
        builder.ToTable("city_pricing_rules");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.BasePrice).HasPrecision(18, 2);
        builder.Property(x => x.Currency).HasMaxLength(10);
        builder.Property(x => x.IsActive).HasDefaultValue(true);
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
