using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("auth_credentials")]
public sealed class AuthCredentialEntity
{
    public Guid Id { get; set; }
    public Guid? PersonId { get; set; }
    public PersonEntity? Person { get; set; }
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public DateTime? LastLogin { get; set; }
    public int FailedAttempts { get; set; }
    public bool IsLocked { get; set; }
    public bool IsActive { get; set; }
}

