using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("vehicles")]
public sealed class VehicleEntity
{
    public Guid Id { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public string Plate { get; set; } = null!;
    public string? Color { get; set; }
    public string? ChassisNumber { get; set; }
    public Guid? TypeVehicleId { get; set; }
    public TypeVehicleEntity? TypeVehicle { get; set; }
    public Guid? VehicleStateId { get; set; }
    public VehicleStateEntity? VehicleState { get; set; }
    public Guid? OwnerId { get; set; }
    public PersonEntity? Owner { get; set; }
}
