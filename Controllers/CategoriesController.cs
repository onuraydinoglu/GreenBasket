using GreenBasket.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenBasket.Controllers;
public class CategoriesController : Controller
{
    public IActionResult List(string url)
    {
        var category = Repository.GetCategoryByUrl(url);
        var products = Repository.Products;

        if (category != null)
        {
            products = products.Where(p => p.CategoryId == category.CategoryId).ToList();
        }

        var modelView = new HomeViewModel
        {
            Categories = Repository.Categories,
            Category = category,
            SubCategories = Repository.SubCategories,
            Products = products,
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
        var product = Repository.GetProductByUrl(url);

        var model = new HomeViewModel
        {
            Categories = Repository.Categories,
            Product = product
        };

        return View(model);
    }
}