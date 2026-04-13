using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class PaymentProviderEntityConfiguration : IEntityTypeConfiguration<PaymentProviderEntity>
{
    public void Configure(EntityTypeBuilder<PaymentProviderEntity> builder)
    {
        builder.ToTable("payment_providers");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        builder.Property(x => x.IsActive).HasDefaultValue(true);
    }
}

