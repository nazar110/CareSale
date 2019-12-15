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
        public ViewResult AllCars()
        {
            Mocks.MockCars allCars = new Mocks.MockCars();
            return View(allCars.AllCars);
        }
        public ViewResult Details(string brandname, string modelname)
        {
            Mocks.MockCars allCars = new Mocks.MockCars();
            var car = from elem in allCars.AllCars
                      where elem.Brandname == brandname && elem.Modelname == modelname
                      select elem;
            return View(car.First());
        }
        //public string Details(string brandname, string modelname)
        //{
        //    Mocks.MockCars allCars = new Mocks.MockCars();
        //    var car = from elem in allCars.AllCars
        //              where elem.Brandname == brandname && elem.Modelname == modelname
        //              select elem;
        //    return ($"{car.First().Brandname} {car.First().Modelname}: {car.First().LongDescription}");
        //}
    }
}