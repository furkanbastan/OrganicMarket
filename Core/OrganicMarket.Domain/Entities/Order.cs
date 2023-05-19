using OrganicMarket.Domain.Entities.Common;
using OrganicMarket.Domain.Entities.Identity;

namespace OrganicMarket.Domain.Entities;

public class Order : EntityBase
{
    //public decimal TotalPrice { get => OrderProducts?.Where(op => op.OrderId == Id).Sum(op => op.Product.Price) + CargoPrice - Discount ?? 0; }
    public decimal TotalPrice { get; set; }
    public decimal Discount { get; set; } = 0;
    public decimal CargoPrice { get; set; } = 15;
    public bool Completed { get; set; } = false;
    public ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();
    public Guid UserId { get; set; }
    public AppUser User { get; set; }
}
