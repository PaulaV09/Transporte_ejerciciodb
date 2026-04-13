using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("prices")]
public sealed class PriceEntity
{
    public Guid Id { get; set; }
    public Guid? OriginCityId { get; set; }
    public CityEntity? OriginCity { get; set; }
    public Guid? DestinationCityId { get; set; }
    public CityEntity? DestinationCity { get; set; }
    public Guid? TypeVehicleId { get; set; }
    public TypeVehicleEntity? TypeVehicle { get; set; }
    public Guid? TypeLoadId { get; set; }
    public TypeLoadEntity? TypeLoad { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public decimal? SuggestedPrice { get; set; }
    public string? Currency { get; set; }
    public bool IsActive { get; set; }
}

