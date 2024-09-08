using GreenBasket.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenBasket.ViewComponents
{
    public class ProductsList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var products = Repository.Products;

            return View(products);
        }
    }
}
