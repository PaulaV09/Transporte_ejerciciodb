using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("person_roles")]
public sealed class PersonRoleEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public Guid? PersonId { get; set; }
    public PersonEntity? Person { get; set; }
}

