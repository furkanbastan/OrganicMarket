using Microsoft.AspNetCore.Mvc;
using OrganicMarket.App.Models;

namespace OrganicMarket.App.Controllers;

public class BasketController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
