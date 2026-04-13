using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("leads")]
public sealed class LeadEntity
{
    public Guid Id { get; set; }
    public Guid? CustomerId { get; set; }
    public CustomerEntity? Customer { get; set; }
    public Guid? TypeLoadId { get; set; }
    public TypeLoadEntity? TypeLoad { get; set; }
    public Guid? OriginCityId { get; set; }
    public CityEntity? OriginCity { get; set; }
    public Guid? DestinationCityId { get; set; }
    public CityEntity? DestinationCity { get; set; }
    public decimal? Weight { get; set; }
    public decimal? Volume { get; set; }
    public DateTime? PickupDate { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public decimal? Budget { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
}

