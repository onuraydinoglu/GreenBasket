using GreenBasket.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenBasket.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Categories = Repository.Categories
            };
            return View(model);
        }
        public IActionResult Product()
        {
            var model = new HomeViewModel
            {
                Categories = Repository.Categories
            };
            return View(model);
        }
        public IActionResult Category()
        {
            var model = new HomeViewModel
            {
                Categories = Repository.Categories
            };
            return View(model);
        }
    }
}