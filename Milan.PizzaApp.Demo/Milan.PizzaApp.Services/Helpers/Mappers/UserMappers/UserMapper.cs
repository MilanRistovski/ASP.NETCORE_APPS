using Milan.PizzaApp.DataAccess.ViewModels;
using Milan.PizzaApp.Demo.Models;
using Milan.PizzaApp.Services.Helpers.Mappers.OrderMappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Milan.PizzaApp.Services.Helpers.Mappers.UserMappers
{
    public static class UserMapper
    {
        public static User UserVMtoUser(UserVM model)
        {
            return new User()
            {
                Address = model.Address,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Phone = model.Phone
            };
        }

        public static UserVM UserToUserVM(User model)
        {
            return new UserVM()
            {
                Address = model.Address,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Phone = model.Phone
            };
        }

        public static List<User> UsersVMtoUsers(List<UserVM> models)
        {
            return models.Select(userVM => new User()
            {
                Address = userVM.Address,
                FirstName = userVM.FirstName,
                LastName = userVM.LastName,
                Phone = userVM.Phone
            }).ToList();
        }

        public static List<UserVM> UsersToUsersVM(List<User> models)
        {
            return models.Select(user => new UserVM()
            {
                Address = user.Address,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                Orders = OrderMapper.OrdersToOrdersVM(user.Orders)
            }).ToList();
        }
    }

}
