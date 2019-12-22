using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using savy.data.Contexts;
using savy.contracts.Repository;
using savy.logics.Managers;
using savy.logics.Validators;
using savy.Contracts.Validators;
using savy.logics.Handlers;
using savy.contracts.Handlers;
using savy.contracts.Factories;
using savy.logics.Factories;

namespace savy.Web.Client
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
            services.AddMvc();
            services.AddDbContext<savyDbContext>();
            services.AddTransient<ILogger, Logger>();
            services.AddTransient<IValidator<Product>, ProductValidator>();
            services.AddTransient<IExceptionHandler, ExceptionHandler>();
            services.AddTransient<IEntityFactory<Product>, ProductFactory>();
            services.AddTransient<IProductRepository, ProductManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
