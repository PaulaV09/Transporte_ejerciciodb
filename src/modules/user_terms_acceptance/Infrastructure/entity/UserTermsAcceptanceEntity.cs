using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("user_terms_acceptance")]
public sealed class UserTermsAcceptanceEntity
{
    public Guid Id { get; set; }
    public Guid? PersonId { get; set; }
    public PersonEntity? Person { get; set; }
    public Guid? LegalTermId { get; set; }
    public LegalTermEntity? LegalTerm { get; set; }
    public DateTime AcceptedAt { get; set; }
}


