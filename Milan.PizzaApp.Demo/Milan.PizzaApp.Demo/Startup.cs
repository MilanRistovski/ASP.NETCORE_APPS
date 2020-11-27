using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Milan.PizzaApp.DataAccess.DB;
using Milan.PizzaApp.DataAccess.Domain.Repositories;
using Milan.PizzaApp.Demo.Domain.Interfaces;
using Milan.PizzaApp.Demo.Models;
using Milan.PizzaApp.Services.Helpers.DIHelper;
using Milan.PizzaApp.Services.Interfaces;
using Milan.PizzaApp.Services.Services;

namespace Milan.PizzaApp.Demo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            // When we register a type as Transient, every time a new instance is created. 
            // Transient creates new instance for every service/ controller as well as for every request and every user.


            //services.AddTransient<IRepository<Pizza>, PizzaRepository>();
            //services.AddTransient<IRepository<Order>, OrderRepository>();
            //services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IPizzaService, PizzaService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IUserService, UserService>();



            DInjector.RegisterRepositories(services, Configuration);

            services.AddControllersWithViews();
            services.AddDbContext<PizzaDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PizzaAppDatabaseConnectionString")));
            // ^^^^^^^  CAN BE MOVED TO DIHelper/DInjector.cs class with a method RegisterRepositories. Commented for simplicity and clarity

            //services.AddTransient<IPizzaService, PizzaService>();
            //services.AddTransient<IOrderService, OrderService>();
            //services.AddTransient<IUserService, UserService>();
            //DInjector.RegisterRepositories(services, Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
