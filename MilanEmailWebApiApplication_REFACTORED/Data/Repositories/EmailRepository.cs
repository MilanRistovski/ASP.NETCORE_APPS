using Data.DatabaseContext;
using Data.Interfaces;
using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class EmailRepository : IRepository<Email>
    {
        private MilanEmailDataBaseContext _context;
        public EmailRepository(MilanEmailDataBaseContext context)  //injecting DBContext into EmailRepository
        {
            _context = context;
        }
        public ICollection<Email> GetAll()
        {
            return _context.Emails.ToList();
        }

        public Email GetById(int id)
        {
            return GetAll().SingleOrDefault(email => email.Id == id);
        }

        public void Insert(Email entity)
        {
            _context.Emails.Add(entity);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var emailToBeDeleted = _context.Emails.SingleOrDefault(email => email.Id == id);
            if (emailToBeDeleted == null) return;
            
            _context.Emails.Remove(emailToBeDeleted);
            _context.SaveChanges();
        }

        public void Update(Email entity)
        {
            _context.Emails.Update(entity);
            _context.SaveChanges();
        }
    }
}
