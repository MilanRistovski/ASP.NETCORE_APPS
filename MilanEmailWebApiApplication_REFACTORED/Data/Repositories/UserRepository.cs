﻿using Data.DatabaseContext;
using Data.Interfaces;
using Domain_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Data.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private MilanEmailDataBaseContext _context;
        public UserRepository(MilanEmailDataBaseContext context) //injecting DBContext into UserRepository
            {
             _context = context;
            }
        public ICollection<User> GetAll()
        {
            return _context.Users.Include(x => x.Emails).ToList();
        }

        public User GetById(int id)
        {
            //  return _context.Users.Include(x=>x.Emails).SingleOrDefault(x => x.Id == id);
            return GetAll().SingleOrDefault(x => x.Id == id);
        }

        public void Insert(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var userToDelete = _context.Users.SingleOrDefault(user => user.Id == id);
            if (userToDelete != null) 
            {
                _context.Users.Remove(userToDelete);
                _context.SaveChanges();
            }
        }

        public void Update(User entity)
        {
            _context.Users.Update(entity);
            _context.SaveChanges();
        }
    }
}
