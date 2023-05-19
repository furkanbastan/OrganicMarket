using Microsoft.AspNetCore.Mvc;
using OrganicMarket.App.Models;

namespace OrganicMarket.App.Controllers;

public class OrderController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Payment()
    {
        var order = new OrderDto{
            Adresses = new List<AdressDto>{
                new AdressDto{Name="Customer", Surname="1", Adress="blablabla", City="San Francisco", District="San Andreas", Neighbourhood ="Küpçüler", Tel="012", Title="Ev Adresi"},
                new AdressDto{Name="Customer", Surname="1", Adress="blablabla", City="San Francisco", District="San Andreas", Neighbourhood ="Küpçüler", Tel="012", Title="İş Adresi"},
                new AdressDto{Name="Customer", Surname="1", Adress="blablabla", City="San Francisco", District="San Andreas", Neighbourhood ="Küpçüler", Tel="012", Title="Okul Adresi"}
            },
            Basket = new BasketDto{Discount = 0, ProductCount = 3, ShippingPrice = 10, TotalPrice = 100}
        };
        return View(order);
    }
}
