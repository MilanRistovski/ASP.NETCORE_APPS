using Milan.PizzaApp.Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Milan.PizzaApp.DataAccess.Domain.Interfaces
{
    public interface IStaticDb
    {
        IEnumerable<User> GetUsers();
        IEnumerable<Pizza> GetPizzas();
        IEnumerable<Order> GetOrders();
    }
}
