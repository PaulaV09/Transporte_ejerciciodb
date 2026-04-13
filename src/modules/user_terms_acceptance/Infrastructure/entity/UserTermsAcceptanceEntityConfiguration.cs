using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class UserTermsAcceptanceEntityConfiguration : IEntityTypeConfiguration<UserTermsAcceptanceEntity>
{
    public void Configure(EntityTypeBuilder<UserTermsAcceptanceEntity> builder)
    {
        builder.ToTable("user_terms_acceptance");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.AcceptedAt).IsRequired().HasColumnType("datetime(6)").HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
        builder.HasOne(x => x.Person)
            .WithMany()
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.LegalTerm)
            .WithMany()
            .HasForeignKey(x => x.LegalTermId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

