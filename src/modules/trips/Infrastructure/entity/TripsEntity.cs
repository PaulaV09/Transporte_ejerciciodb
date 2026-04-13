using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("trips")]
public sealed class TripEntity
{
    public Guid Id { get; set; }
    public Guid? LeadId { get; set; }
    public LeadEntity? Lead { get; set; }
    public decimal? FinalPrice { get; set; }
    public string? TrackingNumber { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public DateOnly? PickupDate { get; set; }
    public Guid? TripStateId { get; set; }
}
