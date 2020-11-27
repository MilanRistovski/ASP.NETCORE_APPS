using Domain_Models.Models;
using DTO_Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappings
{
    public static class EmailMapper
    {
        public static EmailModel EmailToEmailModel(Email email) 
        {
            return new EmailModel()
            {
                Id = email.Id,
                Text = email.Text,
                Category = email.Category,
                Headline = email.Headline,
                UserId = email.UserId
            };
        }

        public static Email EmailModelToEmail(EmailModel email) 
        {
            return new Email()
            {
                Id = email.Id,
                Text = email.Text,
                Category = email.Category,
                Headline = email.Headline,
                UserId = email.UserId
            };
        }

        public static List<EmailModel> EmailsToEmailModels(List<Email> emails)
        {
            return emails.Select(email => new EmailModel()
            {
                Id = email.Id,
                Text = email.Text,
                Category = email.Category,
                Headline = email.Headline,
                UserId = email.UserId
            }).ToList();
        }

        public static List<Email> EmailModelsToEmails(List<EmailModel> emails)
        {
            return emails.Select(email => new Email()
            {
                Id = email.Id,
                Text = email.Text,
                Category = email.Category,
                Headline = email.Headline,
                UserId = email.UserId
            }).ToList();
        }
    }
}
