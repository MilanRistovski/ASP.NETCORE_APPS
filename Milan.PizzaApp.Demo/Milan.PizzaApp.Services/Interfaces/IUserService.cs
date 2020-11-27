using Milan.PizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Milan.PizzaApp.Services.Interfaces
{
    public interface IUserService
    {
        List<UserVM> GetAllUsers();
        List<UserVM> GetUsersByName(string name);
        string CreateNewUser(UserVM model);
    }
}
