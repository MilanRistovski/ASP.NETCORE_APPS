using Data.Interfaces;
using Domain_Models.Models;
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
        public void AddEmail(Email email)
        {
            _emailRepo.Insert(email);
        }

        public void DeleteEmail(int id)
        {
            _emailRepo.Remove(id);
        }

        public List<Email> GetAllEmails()
        {
            return _emailRepo.GetAll().ToList();
        }

        public Email GetEmailById(int id)
        {
            return _emailRepo.GetById(id);
        }

        public void UpdateEmail(Email email)
        {
            _emailRepo.Update(email);
        }
    }
}
