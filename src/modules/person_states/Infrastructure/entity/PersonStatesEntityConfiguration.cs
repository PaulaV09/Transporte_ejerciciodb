using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

public sealed class PersonStateEntityConfiguration : IEntityTypeConfiguration<PersonStateEntity>
{
    public void Configure(EntityTypeBuilder<PersonStateEntity> builder)
    {
        builder.ToTable("person_states");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
        builder.Property(x => x.Description).HasColumnType("longtext");
    }
}
