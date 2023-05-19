using OrganicMarket.Domain.Entities.Common;
using OrganicMarket.Domain.Entities.Identity;

namespace OrganicMarket.Domain.Entities;

public class Adress : EntityBase
{
    public string Title { get; set; }
    public string City { get; set; }
    public string Neighbourhood { get; set; }
    public string District { get; set; }
    public int PostCode { get; set; }
    public Guid UserId { get; set; }
    public AppUser User { get; set; }
}
