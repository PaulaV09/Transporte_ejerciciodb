using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("load_status_history")]
public sealed class LoadStatusHistoryEntity
{
    public Guid Id { get; set; }
    public Guid? LeadId { get; set; }
    public LeadEntity? Lead { get; set; }
    public string? StatusName { get; set; }
    public Guid? ChangedById { get; set; }
    public PersonEntity? ChangedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? Comments { get; set; }
}
