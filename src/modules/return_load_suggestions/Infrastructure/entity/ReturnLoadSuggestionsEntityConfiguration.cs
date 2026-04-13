using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class ReturnLoadSuggestionEntityConfiguration : IEntityTypeConfiguration<ReturnLoadSuggestionEntity>
{
    public void Configure(EntityTypeBuilder<ReturnLoadSuggestionEntity> builder)
    {
        builder.ToTable("return_load_suggestions");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.MatchScore).HasPrecision(5, 2);
        builder.Property(x => x.CreatedAt).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.HasOne(x => x.Trip)
            .WithMany()
            .HasForeignKey(x => x.TripId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.Lead)
            .WithMany()
            .HasForeignKey(x => x.LeadId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

