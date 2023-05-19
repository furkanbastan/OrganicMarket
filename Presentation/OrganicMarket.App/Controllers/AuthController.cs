using Microsoft.AspNetCore.Mvc;

namespace OrganicMarket.App.Controllers;

public class AuthController : Controller
{
    public IActionResult SignIn() //Giriş Yap
    {
        return View();
    }
    public IActionResult SignUp() //Üye Ol
    {
        return View();
    }
}
