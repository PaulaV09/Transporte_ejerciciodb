using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class PersonRoleEntityConfiguration : IEntityTypeConfiguration<PersonRoleEntity>
{
    public void Configure(EntityTypeBuilder<PersonRoleEntity> builder)
    {
        builder.ToTable("person_roles");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.HasOne(x => x.Person)
            .WithMany()
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
