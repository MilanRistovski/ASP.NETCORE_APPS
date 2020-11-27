using Data.Interfaces;
using Domain_Models.Models;
using DTO_Models;
using DTO_Models.ApiModels;
using Mappings;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.ServiceImplementations
{
    public class UserService : IUserService
    {

        private IRepository<User> _userRepo;

        public UserService(IRepository<User> userRepo) 
        {
            _userRepo = userRepo;
        }

        public void AddUser(RegisterModel user)
        {
            if (string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.ConfirmPassword))
            {
                throw new Exception("Password/Confirm Password is required");
            }
            if (user.Password != user.ConfirmPassword)
            {
                throw new Exception("Password and Confirm password do not match");
            }
            if (string.IsNullOrEmpty(user.FirstName))
            {
                throw new Exception("First Name is required");
            }
            if (user.FirstName.Count() > 50)
            {
                throw new Exception("First Name cannot be more than 50 characters");
            }
            var userToRegister = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
                UserName = user.UserName
            };
            _userRepo.Insert(userToRegister);
        }

        public UserModel Authenticate(LoginModel userModel)
        {
            var user = _userRepo.GetAll().SingleOrDefault(x => x.UserName == userModel.UserName && x.Password == userModel.Password);
            if (user == null) throw new Exception("Credentials(username and password) do not match!");

            var returningUserModel = new UserModel
            {
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
            };
            return returningUserModel;
        }

        public void DeleteUser(int id)
        {
            var user = GetUserById(id);
            if (user == null) throw new Exception("Please specify a valid user id");
            _userRepo.Remove(id);
        }

        public List<UserModel> GetAllUsers()
        {
            return UserMapper.UsersToUserModels(_userRepo.GetAll().ToList());
        }

        public UserModel GetUserById(int id)
        {
            var user = _userRepo.GetById(id);
            if (user == null) throw new Exception("Please specify a valid user ID");
            return UserMapper.UserToUserModel(user);
        }

        public void UpdateUser(UserModel userModel)
        {
            var userToCheck = _userRepo.GetById(userModel.Id);
            if (userToCheck == null) throw new Exception("No user found!");
            if (string.IsNullOrEmpty(userModel.UserName)) throw new Exception("Please specify the User Name");
            if (string.IsNullOrEmpty(userModel.Password)) throw new Exception("Please specify password!");
            if (userModel.FirstName.Count() > 50) throw new Exception("First Name cannot be more than 50 characters");

            var user = UserMapper.UserModelToUser(userModel);
            _userRepo.Update(user);
        }
    }
}
