using Microsoft.AspNetCore.Mvc;

namespace GreenBasket.ViewComponents
{
    public class DashboardHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}