using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarSale.Controllers
{
    public class CarsController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public ViewResult ShowAllCars()
        {
            Mocks.MockCars allCars = new Mocks.MockCars();
            return View(allCars.AllCars);
        }
    }
}