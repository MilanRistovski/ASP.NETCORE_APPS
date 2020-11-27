using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Milan.PizzaApp.DataAccess.DB;

namespace Milan.PizzaApp.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        //.Net-core relies on Duck Typing during migrations and scaffolding
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();

        //public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PizzaDbContext>
        //{
        //    public PizzaDbContext CreateDbContext(string[] args)
        //    {
        //        IConfigurationRoot configuration = new ConfigurationBuilder()
        //            .SetBasePath(Directory.GetCurrentDirectory())
        //            .AddJsonFile("appsettings.json")
        //            .Build();
        //        var builder = new DbContextOptionsBuilder<PizzaDbContext>();
        //        var connectionString = configuration.GetConnectionString("DefaultConnection");
        //        builder.UseSqlServer(connectionString);
        //        return new PizzaDbContext(builder.Options);
        //    }
        //}
    }
}
