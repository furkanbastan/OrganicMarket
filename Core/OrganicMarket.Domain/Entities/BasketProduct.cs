using OrganicMarket.Domain.Entities.Common;

namespace OrganicMarket.Domain.Entities;

public class BasketProduct : IEntityBase
{
    public Guid BasketId { get; set; }
    public Guid ProductId { get; set; }
    public Basket Basket { get; set; }
    public Product Product { get; set; }
}
