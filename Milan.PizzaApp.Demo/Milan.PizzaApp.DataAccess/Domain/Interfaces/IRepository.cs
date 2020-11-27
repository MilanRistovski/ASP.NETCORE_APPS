using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milan.PizzaApp.Demo.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        int Create(T entity);
        int Update(T entity);
        int Delete(int id);
    }
}
