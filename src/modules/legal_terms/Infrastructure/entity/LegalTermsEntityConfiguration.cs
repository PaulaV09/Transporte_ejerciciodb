using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;
public sealed class LegalTermEntityConfiguration : IEntityTypeConfiguration<LegalTermEntity>
{
    public void Configure(EntityTypeBuilder<LegalTermEntity> builder)
    {
        builder.ToTable("legal_terms");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Version).HasMaxLength(10);
        builder.Property(x => x.Content).HasColumnType("longtext");
    }
}

