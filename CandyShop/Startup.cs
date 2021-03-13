using CandyShop.Models;
using CandyShop.Views;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));//17.ADIM Adding Connection String

            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>(); //54.ADIM Implementing Login Page

            services.AddControllersWithViews(); //1.ADIM Configuration and Routing
            services.AddScoped<ICategoryRepository, CategoryRepository>(); //6.ADIM Adding Repositories To Services
            services.AddScoped<ICandyRepository, CandyRepository>(); //6.ADIM Adding Repositories To Services
            services.AddScoped<ShoppingCart>(sc => ShoppingCart.GetCart(sc)); //35.ADIM Calculating Total Order and Configuring Sessions

            services.AddScoped<IOrderRepository, OrderRepository>(); //47.ADIM Implementing Order Repository

            services.AddHttpContextAccessor(); //35.ADIM Calculating Total Order and Configuring Sessions
            services.AddSession(); //35.ADIM Calculating Total Order and Configuring Sessions

            services.AddRazorPages();//54.ADIM Implementing Login Page
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection(); //1.ADIM Configuration and Routing
            app.UseStaticFiles(); //1.ADIM Configuration and Routing

            app.UseSession(); //35.ADIM Calculating Total Order and Configuring Sessions
            app.UseRouting();

            app.UseAuthentication(); //53.ADIM Adding Identity To Project


            app.UseEndpoints(endpoints =>
            {
                //1.ADIM Configuration and Routing
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
                //54.ADIM Implementing Login Page
                endpoints.MapRazorPages();
            });
        }
    }
}
