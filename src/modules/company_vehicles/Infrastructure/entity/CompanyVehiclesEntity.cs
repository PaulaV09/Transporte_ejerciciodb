using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("company_vehicles")]
public sealed class CompanyVehicleEntity
{
    public Guid Id { get; set; }
    public Guid? CompanyId { get; set; }
    public TransportCompanyEntity? Company { get; set; }
    public Guid? VehicleId { get; set; }
    public VehicleEntity? Vehicle { get; set; }
    public bool IsActive { get; set; }
}
