using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_Models.ApiModels
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
