using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("user_preferences")]
public sealed class UserPreferenceEntity
{
    public Guid Id { get; set; }
    public Guid? PersonId { get; set; }
    public PersonEntity? Person { get; set; }
    public string Key { get; set; } = null!;
    public string? Value { get; set; }
    public DateTime UpdatedAt { get; set; }
}

