using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class DocumentStatusEntityConfiguration : IEntityTypeConfiguration<DocumentStatusEntity>
{
    public void Configure(EntityTypeBuilder<DocumentStatusEntity> builder)
    {
        builder.ToTable("documents_status");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
        builder.Property(x => x.Description).HasColumnType("longtext");
    }
}
