using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;
public sealed class TripAssignmentEntityConfiguration : IEntityTypeConfiguration<TripAssignmentEntity>
{
    public void Configure(EntityTypeBuilder<TripAssignmentEntity> builder)
    {
        builder.ToTable("trip_assignments");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.AssignedAt).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.HasOne(x => x.Trip)
            .WithMany()
            .HasForeignKey(x => x.TripId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.Person)
            .WithMany()
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.AssignmentRole)
            .WithMany()
            .HasForeignKey(x => x.AssignmentRoleId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

