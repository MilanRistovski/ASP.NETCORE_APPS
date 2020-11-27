using System;
using System.Collections.Generic;
using System.Text;
using Milan.PizzaApp.DataAccess.ViewModels;


namespace Milan.PizzaApp.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderPizzaVM> GetAllOrders();
        OrderPizzaVM GetOrderById(int id);
        string CreateNewOrder(OrderPizzaVM model);
        string DeleteExistingOrder(int id);
    }
}
