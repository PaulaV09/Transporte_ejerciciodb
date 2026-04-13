using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class LoadImageEntityConfiguration : IEntityTypeConfiguration<LoadImageEntity>
{
    public void Configure(EntityTypeBuilder<LoadImageEntity> builder)
    {
        builder.ToTable("load_images");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ImageUrl).IsRequired().HasColumnType("longtext");
        builder.Property(x => x.Description).HasColumnType("longtext");
        builder.Property(x => x.UploadedAt).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.HasOne(x => x.Lead)
            .WithMany()
            .HasForeignKey(x => x.LeadId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

