using GreenBasket.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenBasket.Controllers
{
    public class MyCardController : Controller
    {
        public IActionResult ShopCard()
        {
            var model = new HomeViewModel
            {
                Categories = Repository.Categories
            };
            return View(model);
        }
    }
}