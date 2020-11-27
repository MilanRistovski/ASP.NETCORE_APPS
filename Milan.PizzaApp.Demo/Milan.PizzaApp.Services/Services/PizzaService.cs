using Milan.PizzaApp.DataAccess.ViewModels;
using Milan.PizzaApp.Demo.Domain.Enums;
using Milan.PizzaApp.Demo.Domain.Interfaces;
using Milan.PizzaApp.Demo.Models;
using Milan.PizzaApp.Services.Helpers.Mappers.PizzaMappers;
using Milan.PizzaApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Milan.PizzaApp.Services.Services
{
    public class PizzaService : IPizzaService
    {
        private IRepository<Pizza> _pizzaRepository;

        public PizzaService(IRepository<Pizza> pizzaRepo)
        {
            _pizzaRepository = pizzaRepo;
        }
        public List<PizzaVM> GetAllPizzas()
        {
            var pizzas = _pizzaRepository.GetAll();
            return PizzaMapper.PizzasToPizzasVM(pizzas);
        }

        public PizzaVM GetPizzaById(int id)
        {
            var pizza = _pizzaRepository.GetById(id);
            if (pizza == null) return null;
            return PizzaMapper.PizzaToPizzaVM(pizza);
        }

        public List<PizzaVM> GetPizzasBySize(PizzaSize size)
        {
            var pizzas = _pizzaRepository.GetAll().Where(pizza => pizza.Size == size).ToList();
            return PizzaMapper.PizzasToPizzasVM(pizzas);
        }
    }
}
