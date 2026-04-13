using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;
public sealed class ReasonDiscardEntityConfiguration : IEntityTypeConfiguration<ReasonDiscardEntity>
{
    public void Configure(EntityTypeBuilder<ReasonDiscardEntity> builder)
    {
        builder.ToTable("reasons_discards");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Description).HasColumnType("longtext");
    }
}

