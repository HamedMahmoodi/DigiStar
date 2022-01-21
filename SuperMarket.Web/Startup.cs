using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using SuperMarket.Core.Convertors;
using SuperMarket.Core.Services;
using SuperMarket.Core.Services.Interfaces;
using SuperMarket.DataLayer.Context;

namespace SuperMarket.Web
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
            services.AddRazorPages();
            services.AddMvc();

            #region Authentication

            services.AddAuthentication(Options =>
            {
                Options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                Options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                Options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(Options =>
            {
                Options.LoginPath = "/Login";
                Options.LogoutPath = "/Logout";
                Options.ExpireTimeSpan = TimeSpan.FromMinutes(43200);
            });

            #endregion

            #region DataBase Context

            services.AddDbContext<SuperMarketContext>(options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("SuperMarketConnection"));
                }
                );

            #endregion

            #region IoC

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IViewRenderService, RenderViewToString>();

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Use(async (context, next) =>
            {
                await next();
                if(context.Response.StatusCode==404)
                {
                    context.Response.Redirect("/Home/Error404");
                }
            });

            app.UseDeveloperExceptionPage();
            if (env.IsDevelopment())
            {
                
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }
            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();
            app.Use(async (context, next) =>
            {
                // Do work that doesn't write to the Response.
                if (context.Request.Path.StartsWithSegments("/Admin"))
                {
                    if (!context.User.Identity.IsAuthenticated)
                    {
                        context.Response.Redirect("/Login");
                    }
                    else if (!bool.Parse(context.User.FindFirstValue("IsAdmin")))
                    {
                        context.Response.Redirect("/Login");
                    }
                }
                await next.Invoke();
                // Do logging or other work that doesn't write to the Response.
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "Myareas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
