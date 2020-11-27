using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Milan.PizzaApp.Services.Interfaces;

namespace Milan.PizzaApp.Demo.Controllers
{
    public class HomeController : Controller
    {
        private IPizzaService _pizzaService;

            public HomeController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Welcome to Milan's Pizza place";
            ViewData["Heading"] = "Pizza Menu";

            var allPizzas = _pizzaService.GetAllPizzas();
            return View(allPizzas);
        }
        public IActionResult PizzaDetails(int id)
        {

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Welcome to the Contact Page";

            return View();
        }
    }
}
