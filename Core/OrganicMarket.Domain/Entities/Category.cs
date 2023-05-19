using OrganicMarket.Domain.Entities.Common;

namespace OrganicMarket.Domain.Entities;

public class Category : EntityBase
{
    public string Name { get; set; }
    public ICollection<Product> Products { get; set; } = new HashSet<Product>();
}
