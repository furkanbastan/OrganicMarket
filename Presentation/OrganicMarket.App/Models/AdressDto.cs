namespace OrganicMarket.App.Models;

public class AdressDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Adress { get; set; }
    public string City { get; set; } //Şehir, il
    public string District { get; set; } //İlçe
    public string Neighbourhood { get; set; } //Mahalle
    public string Tel { get; set; }
    public string Title { get; set; }
    public static string secilenAdres { get; set; }="";
}
