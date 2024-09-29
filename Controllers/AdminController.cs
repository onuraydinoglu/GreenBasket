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

        public IActionResult Category()
        {
            var categories = Repository.Categories;

            return View(categories);
        }
        public IActionResult CategoryCreat()
        {
            return View();
        }
        public IActionResult CategoryEdit(int id)
        {
            var category = Repository.GetCategoryById(id);
            return View(category);
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
        public IActionResult ProductEdit(int id)
        {
            var product = Repository.GetProductById(id);
            return View(product);
        }
    }
}