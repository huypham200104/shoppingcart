using Microsoft.AspNetCore.Mvc;

namespace ShoppringCart_MVC.Controllers
{
    public class AdminControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
