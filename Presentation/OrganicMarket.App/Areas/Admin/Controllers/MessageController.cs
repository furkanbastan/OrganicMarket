using Microsoft.AspNetCore.Mvc;

namespace OrganicMarket.App.Areas.Admin.Controllers;

[Area("Admin")]
public class MessageController : Controller
{
    public IActionResult GetAllMessages()
    {
        return View();
    }
}
