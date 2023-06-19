using Microsoft.AspNetCore.Mvc;

namespace DealershipManagementSystem
{
    public class CarShowroomController : Controller
    {
		public ViewResult Index()
		{
			ViewBag.Title = "Main page";
			return View();
		}

		[Route("CarShowroom/ElectricCarInfo/{model}")]
		public ViewResult ElectricCarInfo(string model)
		{
			ViewBag.Title = model;
			return View();
		}

		public ViewResult ElectricCarsCatalog()
        {
			ViewBag.Title = "Electric Cars";
			return View();
        }
    }
}
