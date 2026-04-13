using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class AssignmentRoleEntityConfiguration : IEntityTypeConfiguration<AssignmentRoleEntity>
{
    public void Configure(EntityTypeBuilder<AssignmentRoleEntity> builder)
    {
        builder.ToTable("assignment_role");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Description).HasColumnType("longtext");
    }
}

