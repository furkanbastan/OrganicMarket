using OrganicMarket.Domain.Entities.Common;
using OrganicMarket.Domain.Enums;

namespace OrganicMarket.Domain.Entities;

public class Product : EntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int ViewCount { get; set; }
    public int FavoriteCount { get; set; }
    public decimal Price { get; set; }
    public SalesUnits SalesUnit { get; set; }
    public Guid SupplierId { get; set; }
    public Supplier Supplier { get; set; }
    public Guid ImageId { get; set; }
    public Image Image { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();
    public ICollection<BasketProduct> BasketProducts { get; set; } = new HashSet<BasketProduct>();
}
