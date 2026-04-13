using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("trip_assignments")]
public sealed class TripAssignmentEntity
{
    public Guid Id { get; set; }
    public Guid? TripId { get; set; }
    public TripEntity? Trip { get; set; }
    public Guid? PersonId { get; set; }
    public PersonEntity? Person { get; set; }
    public Guid? AssignmentRoleId { get; set; }
    public AssignmentRoleEntity? AssignmentRole { get; set; }
    public DateTime AssignedAt { get; set; }
}

