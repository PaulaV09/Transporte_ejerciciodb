using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class MessageTypeEntityConfiguration : IEntityTypeConfiguration<MessageTypeEntity>
{
    public void Configure(EntityTypeBuilder<MessageTypeEntity> builder)
    {
        builder.ToTable("message_type");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
        builder.Property(x => x.Description).HasColumnType("longtext");
    }
}
