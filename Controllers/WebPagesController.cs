using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DealershipManagementSystem
{
    public class WebPagesController : Controller
    {
		public ViewResult ElectricCarCharacteristics()
		{
			return View();
		}

		public ViewResult ElectricCarsCatalog()
        {
            return View();
        }
    }
}
