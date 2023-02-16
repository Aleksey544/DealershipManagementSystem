using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DealershipManagementSystem
{
    public class IndexController : Controller
    {
        public ViewResult ShowCars()
        {
            return View();
        }
    }
}
