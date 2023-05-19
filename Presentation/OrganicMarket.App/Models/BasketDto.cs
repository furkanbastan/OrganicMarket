namespace OrganicMarket.App.Models;

public class BasketDto
{
    public int TotalPrice { get; set; }
    public int ProductCount { get; set; }
    public int ShippingPrice { get; set; }
    public int Discount { get; set; } //indirim
}
