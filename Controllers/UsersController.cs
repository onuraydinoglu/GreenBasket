using GreenBasket.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenBasket.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Register()
        {
            var model = new HomeViewModel
            {
                Categories = Repository.Categories
            };

            return View(model);
        }

        public IActionResult Login()
        {
            var model = new HomeViewModel
            {
                Categories = Repository.Categories
            };
            return View(model);
        }
    }
}