﻿using AutoGeneratedSystem.DataAccess.Data;
using AutoGeneratedSystem.Services;
using Microsoft.EntityFrameworkCore;

namespace AutoGeneratedSystem.Server
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddAutoMapper(configAction =>
            {
                configAction.AddMaps(new[] { typeof(Program).Assembly });
            });
            services.AddDbContext<AutogeneratedsystemDatabaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Default"));
            });
            services.AddTransient<ApplicationUserService>();
            services.AddTransient<ApplicationRoleService>();
            services.AddTransient<StoreService>();
            services.AddTransient<CompanyService>();
            services.AddTransient<ApplicationUserApplicationRoleService>();
            services.AddTransient<ProductService>();
            services.AddTransient<ApplicationUserOrderService>();
            services.AddTransient<ApplicationUserOrderDetailService>();

            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public static void ConfigureApp(WebApplication app)
        {
            app.UseSwagger();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();


            app.MapRazorPages();
            app.MapControllers();
            app.MapFallbackToFile("index.html");
            app.UseSwaggerUI();
        }
    }
}
