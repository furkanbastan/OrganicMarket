using OrganicMarket.Domain.Entities.Common;
using OrganicMarket.Domain.Entities.Identity;

namespace OrganicMarket.Domain.Entities;

public class Basket : EntityBase
{
    //public decimal BasketPrice { get => BasketProducts?.Where(bp => bp.BasketId == Id).Sum(bp => bp.Product.Price) ?? 0;  }
    public decimal BasketPrice { get; set; }
    public bool BeingOrder { get; set; } = false;
    public int ProductCount { get; set; } = 0;
    public ICollection<BasketProduct> BasketProducts { get; set; } = new HashSet<BasketProduct>();
    public Guid UserId { get; set; }
    public AppUser User { get; set; }
}
