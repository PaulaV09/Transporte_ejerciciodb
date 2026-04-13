using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class DocumentCategoryEntityConfiguration : IEntityTypeConfiguration<DocumentCategoryEntity>
{
    public void Configure(EntityTypeBuilder<DocumentCategoryEntity> builder)
    {
        builder.ToTable("document_category");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Description).HasColumnType("longtext");
    }
}