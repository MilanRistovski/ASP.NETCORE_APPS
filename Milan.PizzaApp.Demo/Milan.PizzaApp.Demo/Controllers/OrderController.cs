using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Milan.PizzaApp.DataAccess.ViewModels;
using Milan.PizzaApp.Demo.Models;
using Milan.PizzaApp.Services.Interfaces;

namespace Milan.PizzaApp.Demo.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private IPizzaService _pizzaService;
        private IUserService _userService;

        public OrderController(IOrderService orderService, IPizzaService pizzaService, IUserService userService )
        {
            _pizzaService = pizzaService;
            _orderService = orderService;
            _userService = userService;
        }

        // GET: Order
        public ActionResult Index(int id, string error)
        {
            ViewBag.Error = error == null ? "" : error;

            var pizza = _pizzaService.GetPizzaById(id);
            var order = new OrderPizzaVM() { Pizza = pizza };
            return View(order);
        }

        [HttpPost]
        public IActionResult Index (OrderPizzaVM orderModel)
        {
            if (string.IsNullOrEmpty(orderModel.User.Address))
            {
                return RedirectToAction("Index", "Order", new { id = orderModel.Pizza.Id, error = "All fields are required" });

            }
            var pizza = _pizzaService.GetPizzaById(orderModel.Pizza.Id);
            orderModel.Pizza = pizza;
            _userService.CreateNewUser(orderModel.User);
            _orderService.CreateNewOrder(orderModel);

            return RedirectToAction("OrderMenu");
        }
        
        public IActionResult OrderMenu()
        {
            var orders = _orderService.GetAllOrders();
            return View(orders);
        }
    }
}