using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("load_points")]
public sealed class LoadPointEntity
{
    public Guid Id { get; set; }
    public Guid? LeadId { get; set; }
    public LeadEntity? Lead { get; set; }
    public string Address { get; set; } = null!;
    public Point? LocationPoint { get; set; }
    public string? PointType { get; set; }
    public string? ContactPerson { get; set; }
    public string? ContactPhone { get; set; }
}
