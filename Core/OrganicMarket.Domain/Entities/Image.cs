using OrganicMarket.Domain.Entities.Common;

namespace OrganicMarket.Domain.Entities;

public class Image : EntityBase
{
    public string FileType { get; set; }
    public string FileName { get; set; }

    public ICollection<Product> Products { get; set; } = new HashSet<Product>();
}
