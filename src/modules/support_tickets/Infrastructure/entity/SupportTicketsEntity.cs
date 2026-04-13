using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("support_tickets")]
public sealed class SupportTicketEntity
{
    public Guid Id { get; set; }
    public Guid? PersonId { get; set; }
    public PersonEntity? Person { get; set; }
    public string Subject { get; set; } = null!;
    public string? Description { get; set; }
    public string? Status { get; set; }
    public string? Priority { get; set; }
    public DateTime CreatedAt { get; set; }
}

