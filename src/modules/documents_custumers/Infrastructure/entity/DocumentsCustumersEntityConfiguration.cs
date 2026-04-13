using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class DocumentCustomerEntityConfiguration : IEntityTypeConfiguration<DocumentCustomerEntity>
{
    public void Configure(EntityTypeBuilder<DocumentCustomerEntity> builder)
    {
        builder.ToTable("documents_customers");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.DocumentNumber).HasMaxLength(50);
        builder.Property(x => x.ImageUrl).HasColumnType("longtext");
        builder.HasOne(x => x.Customer)
            .WithMany()
            .HasForeignKey(x => x.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.TypeDocument)
            .WithMany()
            .HasForeignKey(x => x.TypeDocumentId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.DocumentState)
            .WithMany()
            .HasForeignKey(x => x.DocumentStateId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
