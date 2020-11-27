using Milan.PizzaApp.DataAccess.ViewModels;
using Milan.PizzaApp.Demo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Milan.PizzaApp.Services.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaVM> GetAllPizzas();
        PizzaVM GetPizzaById(int id);
        List<PizzaVM> GetPizzasBySize(PizzaSize size);
    }
}
