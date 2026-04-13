using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class TransportCompanyEntityConfiguration : IEntityTypeConfiguration<TransportCompanyEntity>
{
    public void Configure(EntityTypeBuilder<TransportCompanyEntity> builder)
    {
        builder.ToTable("transport_companies");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Nit).IsRequired().HasMaxLength(20);
        builder.HasIndex(x => x.Nit).IsUnique();
        builder.Property(x => x.Address).HasMaxLength(255);
        builder.Property(x => x.Phone).HasMaxLength(20);
        builder.Property(x => x.Email).HasMaxLength(100);
        builder.HasOne(x => x.LegalRepresentative)
            .WithMany()
            .HasForeignKey(x => x.LegalRepresentativeId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.CompanyState)
            .WithMany()
            .HasForeignKey(x => x.CompanyStateId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
