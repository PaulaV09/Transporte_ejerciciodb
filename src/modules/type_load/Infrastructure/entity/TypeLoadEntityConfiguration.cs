using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class TypeLoadEntityConfiguration : IEntityTypeConfiguration<TypeLoadEntity>
{
    public void Configure(EntityTypeBuilder<TypeLoadEntity> builder)
    {
        builder.ToTable("type_load");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Description).HasColumnType("longtext");
    }
}

