using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class BlacklistEntityConfiguration : IEntityTypeConfiguration<BlacklistEntity>
{
    public void Configure(EntityTypeBuilder<BlacklistEntity> builder)
    {
        builder.ToTable("blacklist");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Type).HasMaxLength(20);
        builder.Property(x => x.Reason).HasColumnType("longtext");
        builder.Property(x => x.BannedAt).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
    }
}
