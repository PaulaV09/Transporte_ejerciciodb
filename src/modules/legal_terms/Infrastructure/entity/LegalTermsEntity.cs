using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("legal_terms")]
public sealed class LegalTermEntity
{
    public Guid Id { get; set; }
    public string? Version { get; set; }
    public string? Content { get; set; }
    public DateOnly? PublishedAt { get; set; }
}

