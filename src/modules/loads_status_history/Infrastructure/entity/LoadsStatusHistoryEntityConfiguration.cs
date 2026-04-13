using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class LoadStatusHistoryEntityConfiguration : IEntityTypeConfiguration<LoadStatusHistoryEntity>
{
    public void Configure(EntityTypeBuilder<LoadStatusHistoryEntity> builder)
    {
        builder.ToTable("load_status_history");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.StatusName).HasMaxLength(50);
        builder.Property(x => x.CreatedAt).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.Property(x => x.Comments).HasColumnType("longtext");
        builder.HasOne(x => x.Lead)
            .WithMany()
            .HasForeignKey(x => x.LeadId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.ChangedBy)
            .WithMany()
            .HasForeignKey(x => x.ChangedById)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
