using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Milan.PizzaApp.DataAccess.DB;
using Milan.PizzaApp.DataAccess.Domain.Repositories;
using Milan.PizzaApp.Demo.Domain.Interfaces;
using Milan.PizzaApp.Demo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Milan.PizzaApp.Services.Helpers.DIHelper
{
    public static class DInjector
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PizzaDbContext>(options => options.
                UseSqlServer(configuration.GetConnectionString("PizzaAppDatabaseConnectionString")));
            services.AddTransient<IRepository<Pizza>, PizzaRepository>();
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<User>, UserRepository>();

            //services.AddDbContext<PizzaDbContext>(options =>
            //options.UseSqlServer(
            //configuration.GetConnectionString("DefaultConnection"),
            //b => b.MigrationsAssembly(typeof(PizzaDbContext).Assembly.FullName)));

            return services;
        }
    }
}
