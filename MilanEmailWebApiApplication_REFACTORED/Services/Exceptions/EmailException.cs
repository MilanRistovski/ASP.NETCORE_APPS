using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Exceptions
{
        public class EmailException : Exception
    {
        public int? EmailId { get; set; }
        public int UserId { get; set; }
        public EmailException() : base("There has been an issue with the email")
        {

        }
        public EmailException(int? emailId, int userId, string message) : base(message)
        {
            EmailId = emailId;
            UserId = userId;
        }
    }
}
