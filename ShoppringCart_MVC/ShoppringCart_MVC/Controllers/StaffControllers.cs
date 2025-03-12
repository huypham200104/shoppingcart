using Microsoft.AspNetCore.Mvc;

namespace ShoppringCart_MVC.Controllers
{
    public class StaffControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
