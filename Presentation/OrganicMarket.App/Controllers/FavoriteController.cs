using Microsoft.AspNetCore.Mvc;

namespace OrganicMarket.App.Controllers;

public class FavoriteController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
