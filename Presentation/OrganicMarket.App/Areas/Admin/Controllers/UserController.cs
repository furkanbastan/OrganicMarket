using Microsoft.AspNetCore.Mvc;

namespace OrganicMarket.App.Areas.Admin.Controllers;

[Area("Admin")]
public class UserController : Controller
{
    public IActionResult GetAllUsers()
    {
        return View();
    }
}
