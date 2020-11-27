using Milan.PizzaApp.DataAccess.DB;
using Milan.PizzaApp.Demo.Domain.Interfaces;
using Milan.PizzaApp.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Milan.PizzaApp.DataAccess.Domain.Repositories
{
    public class PizzaRepository : IRepository<Pizza>
    {
        private PizzaDbContext _db;
        public PizzaRepository(PizzaDbContext db)
        {
            _db = db;
        }

        public List<Pizza> GetAll()
        {
            return _db.Pizzas.ToList();
        }

        public int Create (Pizza entity)
        {
            if (_db.Pizzas.SingleOrDefault(x => x.Id == entity.Id) != null)
                return -1;
            _db.Pizzas.Add(entity);
            return _db.SaveChanges();
        }

        public int Delete(int id)
        {
            var pizza = _db.Pizzas.SingleOrDefault(x => x.Id == id);
            if (pizza == null) return -1;

            _db.Pizzas.Remove(pizza);
            return _db.SaveChanges();
        }

        public int Update(Pizza entity)
        {
            var pizza = _db.Pizzas.SingleOrDefault(x => x.Id == entity.Id);
            if (pizza == null) return -1;
            _db.Pizzas.Update(entity);
            return _db.SaveChanges();
        }

        public Pizza GetById(int id)
        {
            return _db.Pizzas.SingleOrDefault(x => x.Id == id);
        }
    }
}
