namespace OrganicMarket.App.Models;

public class OrderDto
{
    public List<AdressDto> Adresses { get; set; }
    public BasketDto Basket { get; set; }
    public string Adress { get; set; } = "Seçilmedi";
    public int CardNumber { get; set; }
    public int CVV { get; set; }
    public int ExpirationMonth { get; set; }
    public int ExpirationYear { get; set; }
}
