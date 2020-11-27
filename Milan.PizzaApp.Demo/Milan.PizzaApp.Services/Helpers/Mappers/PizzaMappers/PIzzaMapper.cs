using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Milan.PizzaApp.DataAccess.ViewModels;
using Milan.PizzaApp.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Milan.PizzaApp.Services.Helpers.Mappers.PizzaMappers
{
    public static class PizzaMapper
    {
        public static Pizza PizzaVMtoPizza(PizzaVM model)
        {
            return new Pizza()
            {
                Size = model.Size,
                Image = model.Image,
                Name = model.Name,
                Price = model.Price,
                Id = model.Id
            };
        }

        public static PizzaVM PizzaToPizzaVM (Pizza model)
        {
            return new PizzaVM()
            {
                Size = model.Size,
                Image = model.Image,
                Name = model.Name,
                Price = model.Price,
                Id = model.Id
            };
        }

        public static List<Pizza> PizzasVMtoPizzas(List<PizzaVM> models)
        {
            return models.Select(pizzaVM => new Pizza()
            {
                Size = pizzaVM.Size,
                Image = pizzaVM.Image,
                Name = pizzaVM.Name,
                Price = pizzaVM.Price,
                Id = pizzaVM.Id
            }).ToList();
        }

        public static List<PizzaVM> PizzasToPizzasVM(List<Pizza> models)
        {
            return models.Select(pizza => new PizzaVM()
            {
                Size = pizza.Size,
                Image = pizza.Image,
                Name = pizza.Name,
                Price = pizza.Price,
                Id = pizza.Id
            }).ToList();
        }
    }
}
