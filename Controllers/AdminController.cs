using GreenBasket.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenBasket.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            var products = Repository.Products;

            return View(products);
        }
        public IActionResult ProductCreat()
        {
            return View();
        }

        public IActionResult Category()
        {
            var categories = Repository.Categories;

            return View(categories);
        }
        public IActionResult CategoryCreat()
        {
            return View();
        }
    }
}