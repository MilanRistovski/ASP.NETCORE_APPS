using System;
using Domain_Models.Enums;
using Domain_Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.DatabaseContext
{
    public partial class MilanEmailDataBaseContext : DbContext
    {
        public MilanEmailDataBaseContext()
        {
        }

        public MilanEmailDataBaseContext(DbContextOptions<MilanEmailDataBaseContext> options)
            : base(options)
        {
        }

		// Unable to generate entity type for table 'dbo.CustomerDiagram'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.CustomerDiagramTest'. Please see the warning messages.

		public DbSet<User> Users { get; set; }
		public DbSet<Email> Emails { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			Seed(modelBuilder);
			base.OnModelCreating(modelBuilder);
		}
		public void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>()
				.HasData(
					new User()
					{
						Id = 1,
						FirstName = "Steve",

						LastName = "Stevenson",

						UserName = "steve123",
						Password = "12345"
					},
					new User()
					{
						Id = 2,
						FirstName = "Robert",

						LastName = "Robertson",

						UserName = "R.R",
						Password = "67890"
					},
					new User()
					{
						Id = 3,
						FirstName = "James",

						LastName = "Jameson",

						UserName = "James",
						Password = "123456"
					}
				);
			modelBuilder.Entity<Email>()
				.HasData(
					new Email()
					{
						Id = 1,
						Text = "Check out our new blog post regarding the newest changes in business due to the global pandemic",
						Headline = "Corona Virus Business Update",
						Category = CategoryType.Business,
						UserId = 1
					},
					new Email()
					{
						Id = 2,
						Text = "Explore the newest investment opportunities",
						Headline = "New Investment opportunities",
						Category = CategoryType.Business,
						UserId = 1
					},
					new Email()
					{
						Id = 3,
						Text = "Don't forget about your upcoming medical appointment ",
						Headline = "Doctor appointment",
						Category = CategoryType.Personal,
						UserId = 2
					},
					new Email()
					{
						Id = 4,
						Text = "Do the dishes, laundry and buy groceries",
						Headline = "Chores",
						Category = CategoryType.Personal,
						UserId = 1
					},
					new Email()
					{
						Id = 5,
						Text = "New Work Meeting related to quarterly results",
						Headline = "Upcoming Meeting",
						Category = CategoryType.Work,
						UserId = 2
					},
					new Email()
					{
						Id = 6,
						Text = "Learn through various books and official documentation",
						Headline = "Learn Angular",
						Category = CategoryType.School,
						UserId = 1
					},
					new Email()
					{
						Id = 7,
						Text = "Read books, watch tutorials and follow documentation",
						Headline = "Learn ASP.NET Core Web APi",
						Category = CategoryType.School,
						UserId = 3
					}
				);
		}

		
    }
}
