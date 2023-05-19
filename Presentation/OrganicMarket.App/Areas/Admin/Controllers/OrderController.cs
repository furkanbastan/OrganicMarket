using Microsoft.AspNetCore.Mvc;

namespace OrganicMarket.App.Areas.Admin.Controllers;

[Area("Admin")]
public class OrderController : Controller
{
    public IActionResult GetAllOrders()
    {
        return View();
    }
    public IActionResult GetCompletedOrders()
    {
        return View();
    }
    public IActionResult GetNewOrders()
    {
        return View();
    }
}
