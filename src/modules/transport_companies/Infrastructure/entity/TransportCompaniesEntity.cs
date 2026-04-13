using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("transport_companies")]
public sealed class TransportCompanyEntity
{
    public Guid Id { get; set; }
    public string CompanyName { get; set; } = null!;
    public string Nit { get; set; } = null!;
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public Guid? LegalRepresentativeId { get; set; }
    public PersonEntity? LegalRepresentative { get; set; }
    public Guid? CompanyStateId { get; set; }
    public CompanyStateEntity? CompanyState { get; set; }
}

