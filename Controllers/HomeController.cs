using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GreenBasket.Models;

namespace GreenBasket.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeViewModel
        {
            Categories = Repository.Categories,
            Products = Repository.Products
        };

        return View(viewModel);
    }
}
