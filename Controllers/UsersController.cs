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

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Categories = Repository.Categories,
                Products = Repository.Products
            };
            return View(model);
        }

        public IActionResult Setting()
        {
            var model = new HomeViewModel
            {
                Categories = Repository.Categories,
                Products = Repository.Products
            };
            return View(model);
        }

        public IActionResult Address()
        {
            var model = new HomeViewModel
            {
                Categories = Repository.Categories,
                Products = Repository.Products
            };
            return View(model);
        }

        public IActionResult Payment()
        {
            var model = new HomeViewModel
            {
                Categories = Repository.Categories,
                Products = Repository.Products
            };
            return View(model);
        }


    }
}