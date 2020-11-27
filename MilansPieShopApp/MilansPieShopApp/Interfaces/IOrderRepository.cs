using MilansPieShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilansPieShopApp.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
