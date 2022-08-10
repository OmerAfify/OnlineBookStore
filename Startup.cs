using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using OnlineBookStore.Business_Layer;
using OnlineBookStore.Interfaces;
using OnlineBookStore.Models;

namespace OnlineBookStore
{
    public class Startup
    {
       public IConfiguration Configuration { get; }



        //consstructor
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

           /*Ignore loops and do not serialize navigation objects*/
            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);


            
            services.AddControllersWithViews()
                .AddNewtonsoftJson(options => {
                    options.SerializerSettings.Formatting = Formatting.Indented;
                });



            /*AutoMapper*/
            services.AddAutoMapper(typeof(Startup));


            /*Dependency Injection for DB Context + connection string*/
            services.AddDbContext<OnlineBookStoreDbContext>
                (options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            /*Dependency Injection for ather classes + interfaces*/
             services.AddScoped<IBookItemServices, BookItemServices>();
             services.AddScoped<IBookCategoryServices, BookCategoryServices>();
             services.AddScoped<ISliderServices, SliderServices>();
             services.AddScoped<IOrderServices, OrderServices>();


            /*Idenity Framework service*/
            services.AddIdentity<ApplicationIdentiyUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.User.RequireUniqueEmail = true;

            }).AddEntityFrameworkStores<OnlineBookStoreDbContext>();


            /*Endabiling Session*/
            services.AddSession();
            services.AddHttpContextAccessor();
            services.AddDistributedMemoryCache();

            /*Cookies Settings*/
            services.ConfigureApplicationCookie(options => {

                options.AccessDeniedPath = "/User/AccessDenied";
                options.Cookie.Name = "UserCookie";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(720);
                options.LoginPath="/User/Login";
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;

            });

            

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
                app.UseHsts();
            }


            /*Pipelines Middlewares*/
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthentication();

            app.UseAuthorization();

           
            /*routing middlewares*/
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}");


                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

                });


                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();

                });

        }
    }
}
