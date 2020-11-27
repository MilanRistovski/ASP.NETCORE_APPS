using Domain_Models.Models;
using DTO_Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IEmailService
    {
        List<EmailModel> GetAllEmails();
        EmailModel GetEmailById(int id);
        void AddEmail(EmailModel email);
        void UpdateEmail(EmailModel email);
        void DeleteEmail(int id);


    }
}
