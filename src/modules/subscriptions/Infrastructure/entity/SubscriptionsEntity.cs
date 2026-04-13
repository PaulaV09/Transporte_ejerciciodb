using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Transporte.src.modules.transport.Infrastructure.entity;

[Table("subscriptions")]
public sealed class SubscriptionEntity
{
    public Guid Id { get; set; }
    public Guid? PersonId { get; set; }
    public PersonEntity? Person { get; set; }
    public Guid? SubscriptionTypeId { get; set; }
    public SubscriptionTypeEntity? SubscriptionType { get; set; }
    public Guid? StatusId { get; set; }
    public SubscriptionStateEntity? Status { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public bool IsAutoRenew { get; set; }
}

