using Microsoft.AspNetCore.Identity;
using OrganicMarket.Domain.Entities.Common;

namespace OrganicMarket.Domain.Entities.Identity;

public class AppUser : IdentityUser<Guid>, IEntityBase
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Image Image { get; set; }
    public Guid ImageId { get; set; }//= Guid.Parse("4084c97a-2aa1-4675-b519-69f6fe410633");
    public ICollection<Adress> Adresses { get; set; } = new HashSet<Adress>();
    public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    public ICollection<Basket> Baskets { get; set; } = new HashSet<Basket>();
    public Supplier Supplier { get; set; } = null; //kullanıcı ve tedarikçi arasında 1e hiç ilişkisi
}
