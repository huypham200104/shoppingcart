using Microsoft.AspNetCore.Mvc;
using ShoppringCart_MVC.Models.Entities;
using ShoppringCart_MVC.Models;

namespace ShoppringCart_MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {
            return View();
        }
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                user.CreatedAt = DateTime.Now;
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }
        public IActionResult EditUser(User user) {
            if (ModelState.IsValid)
            {
                user.CreatedAt = DateTime.Now;
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } 
            return View(user);
        }
    }
}
