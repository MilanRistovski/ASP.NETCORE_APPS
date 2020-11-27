using Data.Interfaces;
using Domain_Models.Models;
using DTO_Models.ApiModels;
using Mappings;
using Services.Exceptions;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.ServiceImplementations
{
    public class EmailService : IEmailService
    {
        private IRepository<Email> _emailRepo; 
        public EmailService (IRepository<Email> emailRepo)
        {
            _emailRepo = emailRepo ;
        }
        public void AddEmail(EmailModel emailModel)
        {
            if (string.IsNullOrEmpty(emailModel.Text))
            {
                throw new EmailException(null, emailModel.UserId, "Required text field!!");
            }
            var email = EmailMapper.EmailModelToEmail(emailModel);
            _emailRepo.Insert(email);
        }

        public void AddEmail(Email email)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmail(int id)
        {
            var email = GetEmailById(id);
            if (email == null) throw new Exception("Invalid email ID");
            _emailRepo.Remove(id);
        }

        public List<EmailModel> GetAllEmails()
        {
            var emails = _emailRepo.GetAll().ToList();
            return EmailMapper.EmailsToEmailModels(emails);
        }

        public EmailModel GetEmailById(int id)
        {
            var email = _emailRepo.GetById(id);
            return EmailMapper.EmailToEmailModel(email);
        }

        public void UpdateEmail(EmailModel emailModel)
        {
            var emailCheck = _emailRepo.GetById(emailModel.Id);
            if (emailCheck == null) throw new Exception("No such email to upload");

            if (string.IsNullOrEmpty(emailModel.Text)) 
            {
                throw new Exception("No Text field found. Please put a text field.");
            }
            var email = EmailMapper.EmailModelToEmail(emailModel);
            _emailRepo.Update(email);
        }
    }
}
