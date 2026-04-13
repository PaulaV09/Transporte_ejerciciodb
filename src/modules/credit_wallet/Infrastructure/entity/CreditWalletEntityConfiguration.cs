using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class CreditWalletEntityConfiguration : IEntityTypeConfiguration<CreditWalletEntity>
{
    public void Configure(EntityTypeBuilder<CreditWalletEntity> builder)
    {
        builder.ToTable("credit_wallet");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Balance).IsRequired().HasPrecision(18, 2).HasDefaultValue(0.00m);
        builder.Property(x => x.LastUpdate).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.HasOne(x => x.Person)
            .WithMany()
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
