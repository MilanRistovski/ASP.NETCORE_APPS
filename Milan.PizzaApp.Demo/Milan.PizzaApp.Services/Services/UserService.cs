using Milan.PizzaApp.DataAccess.ViewModels;
using Milan.PizzaApp.Demo.Domain.Interfaces;
using Milan.PizzaApp.Demo.Models;
using Milan.PizzaApp.Services.Helpers.Mappers.UserMappers;
using Milan.PizzaApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Milan.PizzaApp.Services.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepo)
        {
            _userRepository = userRepo;
        }

        public string CreateNewUser(UserVM model)
        {
            var user = UserMapper.UserVMtoUser(model);
            var response = _userRepository.Create(user);
            if (response == -1) return "Not successfull, try again later!";
            return "User was created sucessfully!";

        }

        public List<UserVM> GetAllUsers()
        {
            var users = _userRepository.GetAll();
            return UserMapper.UsersToUsersVM(users);
        }

        public List<UserVM> GetUsersByName(string name)
        {
            var users = _userRepository.GetAll().Where(user => user.FirstName.ToLower() == name.ToLower()).ToList();
            return UserMapper.UsersToUsersVM(users);
        }
    }
}
