using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;
public sealed class TypeDocumentEntityConfiguration : IEntityTypeConfiguration<TypeDocumentEntity>
{
    public void Configure(EntityTypeBuilder<TypeDocumentEntity> builder)
    {
        builder.ToTable("type_document");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.HasOne(x => x.Category)
            .WithMany()
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
