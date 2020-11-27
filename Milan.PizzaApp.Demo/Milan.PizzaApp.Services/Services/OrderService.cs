using Milan.PizzaApp.DataAccess.ViewModels;
using Milan.PizzaApp.Demo.Domain.Interfaces;
using Milan.PizzaApp.Demo.Models;
using Milan.PizzaApp.Services.Helpers.Mappers.OrderMappers;
using Milan.PizzaApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Milan.PizzaApp.Services.Services
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepository;

        public OrderService(IRepository<Order> orderRepo)
        {
            _orderRepository = orderRepo;
        }

        public string CreateNewOrder(OrderPizzaVM model)
        {
            var order = OrderMapper.OrderVMToOrder(model);
            int response = _orderRepository.Create(order);

            if (response == -1) return "Order was not correct. Try again";
            return "Order created successfully!";
        }

        public string DeleteExistingOrder(int id)
        {
            int response = _orderRepository.Delete(id);
            if (response == -1) return "Can not delete. Try again!";
            return "Order deleted successfully";
        }

        public List<OrderPizzaVM> GetAllOrders()
        {
            var orders = _orderRepository.GetAll();
            return OrderMapper.OrdersToOrdersVM(orders);
        }

        public OrderPizzaVM GetOrderById(int id)
        {
            var order = _orderRepository.GetById(id);
            return OrderMapper.OrderToOrderVM(order);
        }
    }
}
