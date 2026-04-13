using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class SubscriptionStateEntityConfiguration : IEntityTypeConfiguration<SubscriptionStateEntity>
{
    public void Configure(EntityTypeBuilder<SubscriptionStateEntity> builder)
    {
        builder.ToTable("subscription_states");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
        builder.Property(x => x.Description).HasColumnType("longtext");
    }
}
