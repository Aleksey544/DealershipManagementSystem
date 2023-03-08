using Microsoft.AspNetCore.Mvc;

namespace DealershipManagementSystem
{
    public class WebPagesController : Controller
    {
		public ViewResult ElectricCarInfo()
		{
			return View();
		}

		public ViewResult ElectricCarsCatalog()
        {
            return View();
        }
    }
}
