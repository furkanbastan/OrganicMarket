using OrganicMarket.Domain.Entities.Common;

namespace OrganicMarket.Domain.Entities;

public class OrderProduct : IEntityBase
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public Order Order { get; set; }
    public Product Product { get; set; }
}
