using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PagedList.Mvc;
using PagedList;
using ReflectionIT.Mvc.Paging;

namespace CarSale.Controllers
{
    public class CarsController : Controller
    {

        public IActionResult Index(int page = 1)
        {
            Mocks.MockCars allCars = new Mocks.MockCars();
            var query = allCars.AllCars;
            var model = PagingList.Create(query, 6, page);
            return View(model);
        }
        public ViewResult AllCars(int page = 1)
        {
            Mocks.MockCars allCars = new Mocks.MockCars();
            var query = allCars.AllCars;
            var model = PagingList.Create(query, 3, page);
            //return View(allCars.AllCars);
            return View(model);
        }
        public ActionResult Details(string brandname, string modelname)
        {
            Mocks.MockCars allCars = new Mocks.MockCars();
            var car = from elem in allCars.AllCars
                      where elem.Brandname == brandname && elem.Modelname == modelname
                      select elem;
            return RedirectToAction("CarDetails", "CarsController", new { Brandname = brandname, Modelname = modelname });
        }
        public ActionResult CarDetails(string brandname, string modelname)
        {
            Mocks.MockCars allCars = new Mocks.MockCars();
            var cars = from elem in allCars.AllCars
                       where elem.Brandname == brandname && elem.Modelname == modelname
                       select elem;
            return View(cars.First());
        }

        public ActionResult SearchCar(string search, int? i)
        {
            return View();
        }
    }
}