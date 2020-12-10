// Copywrite 2020 RipMyPaperToShreds.com - All rights reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential
// Written by: Joshua Trimm <trimmj@etsu.edu>, 6/18/2020
// File Name: Startup.cs

namespace RipMyPaperToShreds.com
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using RipMyPaperToShreds.com.Data;
    using RipMyPaperToShreds.com.Models;
    using RipMyPaperToShreds.com.Services.Hubs;
    using RipMyPaperToShreds.com.Services.Interfaces;

    /// <summary>
    /// Defines the <see cref="Startup" />.
    /// </summary>
    public class Startup
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">The configuration<see cref="IConfiguration"/>.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the Configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        #endregion

        #region Methods

        /// <summary>
        /// The Configure.
        /// </summary>
        /// <param name="app">The app<see cref="IApplicationBuilder"/>.</param>
        /// <param name="env">The env<see cref="IWebHostEnvironment"/>.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "Setdefault",
                   pattern: "{controller}/{action}");

                endpoints.MapControllerRoute(
                    name: "PassingID",
                   pattern: "{controller}/{action}/{id?}");

                endpoints.MapControllerRoute(
                    name: "SetVariables",
                   pattern: "{controller=Home}/{action=SubmitShred}/{id}");

                endpoints.MapControllerRoute(
                    name: "NextPage",
                   pattern: "{controller=Home}/{action=NextPage}/{id}");

                endpoints.MapControllerRoute(
                    name: "NextPage",
                   pattern: "{controller=Home}/{action=SubmitShred}/{id}");

                //endpoints.MapControllerRoute(
                //    name: "Dashboard",
                //   pattern: "{controller=Dashboard}/{action=Index}/{id?}");


                endpoints.MapRazorPages();
                endpoints.MapHub<ShredsHub>("/shredHub");


            });
        }

        /// <summary>
        /// The ConfigureServices.
        /// </summary>
        /// <param name="services">The services<see cref="IServiceCollection"/>.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            //services.AddIdentityCore<ApplicationUser>(cfg => {
            //    cfg.User.RequireUniqueEmail = true;
            //}).AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddControllersWithViews();
            services.AddRazorPages();



            services.AddSignalR();

            services.AddScoped<ISubShreds, Services.Repos.SubShreds>();
            services.AddScoped<IShreds, Services.Repos.Shreds>();
            services.AddScoped<IRips, Services.Repos.Rips>();
            services.AddScoped<IPapers, Services.Repos.Papers>();
            services.AddScoped<IPaperHashes, Services.Repos.PaperHashes>();
            services.AddScoped<IHashTags, Services.Repos.HashTags>();
        }

        #endregion
    }
}
