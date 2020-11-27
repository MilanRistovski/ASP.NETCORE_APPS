using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IEmailService
    {
        List<Email> GetAllEmails();
        Email GetEmailById(int id);
        void AddEmail(Email email);
        void UpdateEmail(Email email);
        void DeleteEmail(int id);


    }
}
