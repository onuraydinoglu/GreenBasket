using Microsoft.AspNetCore.Mvc;

namespace GreenBasket.ViewComponents
{
    public class UserNav : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}