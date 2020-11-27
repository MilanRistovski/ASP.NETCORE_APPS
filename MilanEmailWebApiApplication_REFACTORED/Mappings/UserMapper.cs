using Domain_Models.Models;
using DTO_Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappings
{
    public static class UserMapper
    {
        public static UserModel UserToUserModel(User user) 
        {
            return new UserModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
                UserName = user.UserName,
                Emails = EmailMapper.EmailsToEmailModels(user.Emails.ToList())
            };
        }

        public static User UserModelToUser(UserModel user)
        {
            return new User()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
                UserName = user.UserName,
                Emails = EmailMapper.EmailModelsToEmails(user.Emails.ToList())
            };
        }
        public static List<UserModel> UsersToUserModels (List<User> users)
        {
            return users.Select(user => new UserModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
                Emails = EmailMapper.EmailsToEmailModels(user.Emails.ToList())
            }).ToList();
        }

        public static List<User> UserModelsToUsers(List<UserModel> users)
        {
            return users.Select(user => new User()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
                UserName = user.UserName,
                Emails = EmailMapper.EmailModelsToEmails(user.Emails.ToList())
            }).ToList();
        }

        
    }
}
