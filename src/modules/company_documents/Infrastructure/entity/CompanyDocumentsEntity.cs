using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("company_documents")]
public sealed class CompanyDocumentEntity
{
    public Guid Id { get; set; }
    public Guid? CompanyId { get; set; }
    public TransportCompanyEntity? Company { get; set; }
    public Guid? TypeDocumentId { get; set; }
    public TypeDocumentEntity? TypeDocument { get; set; }
    public string? DocumentNumber { get; set; }
    public DateOnly? ExpirationDate { get; set; }
    public string? ImageUrl { get; set; }
    public Guid? DocumentStateId { get; set; }
    public DocumentStatusEntity? DocumentState { get; set; }
}
