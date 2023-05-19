using OrganicMarket.Domain.Entities.Common;

namespace OrganicMarket.Domain.Entities;

public class Supplier : EntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Product> Products { get; set; } = new HashSet<Product>();
}
