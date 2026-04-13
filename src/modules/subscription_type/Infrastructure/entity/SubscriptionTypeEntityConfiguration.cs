using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;
public sealed class SubscriptionTypeEntityConfiguration : IEntityTypeConfiguration<SubscriptionTypeEntity>
{
    public void Configure(EntityTypeBuilder<SubscriptionTypeEntity> builder)
    {
        builder.ToTable("subscription_type");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Description).HasColumnType("longtext");
        builder.Property(x => x.Price).HasPrecision(18, 2);
    }
}

