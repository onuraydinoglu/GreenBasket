using Microsoft.AspNetCore.Mvc;

namespace GreenBasket.ViewComponents
{
    public class DashboardNav : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}