using Microsoft.AspNetCore.Mvc;

namespace OrganicMarket.App.Areas.Admin.Controllers;

[Area("Admin")]
public class ProductController : Controller
{
    public IActionResult GetAllProducts()
    {
        return View();
    }
    public IActionResult GetNewProducts()
    {
        return View();
    }
    public IActionResult GetProductsBySupplier()
    {
        return View();
    }
    public IActionResult GetMayEndProducts() //Tükenebilecek ürünler
    {
        return View();
    }
    public IActionResult GetSoldOutProducts()
    {
        return View();
    }
}
