using Microsoft.AspNetCore.Mvc;

namespace HexGame.AspNetCoreApp.Controllers
{
    public class SigninController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
