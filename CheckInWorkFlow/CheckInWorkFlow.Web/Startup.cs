
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using CheckInWorkFlow.Data.DataAccess;
using CheckInWorkFlow.Data.Repositories;
using CheckInWorkFlow.Business.Services;

namespace CheckInWorkFlow.Web
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
            services.AddControllersWithViews();
            services.AddDbContext<CheckInContext>(options =>
            options.UseSqlite(Configuration.GetConnectionString("CheckInContext")));
            services.AddScoped(typeof(IRepository < > ), typeof(EFRepository < > ));  
            services.AddScoped<IAppointmentService, AppointmentService>(); 
            services.AddScoped<IPassengerService, PassengerService>(); 
            services.AddScoped<AppointmentRepository>();
 
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                /////Show error page for status code exceptions
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
                
                /////Global exception handling
                app.UseExceptionHandler("/Error");
              //  app.UseDeveloperExceptionPage();
            }
            else
            {
               /////Show error page for status code exceptions
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
                
                /////Global exception handling
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Appointment}/{action=Index}/{id?}");
            });
        }
    }
}
