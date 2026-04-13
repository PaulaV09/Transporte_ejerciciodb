using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;
public sealed class TransactionTypeEntityConfiguration : IEntityTypeConfiguration<TransactionTypeEntity>
{
    public void Configure(EntityTypeBuilder<TransactionTypeEntity> builder)
    {
        builder.ToTable("transaction_types");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Description).HasColumnType("longtext");
    }
}

