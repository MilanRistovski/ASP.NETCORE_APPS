﻿using Milan.PizzaApp.DataAccess.Domain.Interfaces;
using Milan.PizzaApp.Demo.Domain.Enums;
using Milan.PizzaApp.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Milan.PizzaApp.DataAccess
{
    public class StaticDb : IStaticDb
    {
        public IEnumerable<User> GetUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Address = "Bob Street",
                    Phone = 080012312345
                }
            };
        }
        public IEnumerable<Pizza> GetPizzas()
        {
            return new List<Pizza>()
            {
                new Pizza()
                {
                    Id = 1,
                    Name = "Kapri",
                    Price = 7,
                    Size = PizzaSize.Small,
                    Image="Kapri.png"
                },
                new Pizza()
                {
                    Id = 2,
                    Name = "Margarita",
                    Price = 8,
                    Size = PizzaSize.Medium,
                    Image="Margarita.png"
                },
                new Pizza()
                {
                    Id = 3,
                    Name = "Peperoni",
                    Price = 9,
                    Size = PizzaSize.Family,
                    Image="Peperoni.png"
                }
            };
        }
        public IEnumerable<Order> GetOrders()
        {
            return new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    User = GetUsers().ToList()[0],
                    Pizza = GetPizzas().ToList()[0],
                    Delivered = false
                }
            };
        }
    }
}
