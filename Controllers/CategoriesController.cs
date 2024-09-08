using GreenBasket.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenBasket.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult List()
        {
            var modelView = new HomeViewModel
            {
                Categories = Repository.Categories,
                SubCategories = Repository.SubCategories,
                Products = Repository.Products,
                Stores = Repository.Stores
            };

            return View(modelView);
        }

        public IActionResult Details(string url)
        {
            if (url == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var product = Repository.GetById(url);

            return View(product);
        }
    }
}