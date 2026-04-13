using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("drivers_vehicles")]
public sealed class DriverVehicleEntity
{
    public Guid Id { get; set; }
    public Guid? DriverId { get; set; }
    public DriverEntity? Driver { get; set; }
    public Guid? VehicleId { get; set; }
    public VehicleEntity? Vehicle { get; set; }
    public DateTime AssignedAt { get; set; }
    public bool IsActive { get; set; }
}
