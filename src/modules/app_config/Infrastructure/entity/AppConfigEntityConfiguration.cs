using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class AppConfigEntityConfiguration : IEntityTypeConfiguration<AppConfigEntity>
{
    public void Configure(EntityTypeBuilder<AppConfigEntity> builder)
    {
        builder.ToTable("app_config");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ConfigKey).IsRequired().HasMaxLength(100);
        builder.HasIndex(x => x.ConfigKey).IsUnique();
        builder.Property(x => x.ConfigValue).HasColumnType("longtext");
        builder.Property(x => x.Description).HasColumnType("longtext");
    }
}
