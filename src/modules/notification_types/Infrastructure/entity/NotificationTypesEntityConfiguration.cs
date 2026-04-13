using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class NotificationTypeEntityConfiguration : IEntityTypeConfiguration<NotificationTypeEntity>
{
    public void Configure(EntityTypeBuilder<NotificationTypeEntity> builder)
    {
        builder.ToTable("notification_types");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Template).HasColumnType("longtext");
    }
}

