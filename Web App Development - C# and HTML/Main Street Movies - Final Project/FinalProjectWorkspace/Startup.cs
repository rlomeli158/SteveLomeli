using System;
using System.Globalization;
using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

//TODO: Make this namespace match your project - be sure to remove the []
namespace FinalProjectWorkspace
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //This adds the MVC engine and Razor code
            services.AddControllersWithViews();


            //add the connection string for jeremiah Azure account
            //NEW CONNECTION STRING! UNCOMMENT TO WORK ON FINAL DB
            var connectionString = "Server=tcp:finalprojectteam17.database.windows.net,1433;Initial Catalog=finalprojectteam17;Persist Security Info=False;User ID=burtram;Password=basic123!;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            //OLD CONNECTION STRING! UNCOMMENT TO WORK ON OLD DB
            //var connectionString = "Server=tcp:t17333kr1.database.windows.net,1433;Initial Catalog=t17333kr1;Persist Security Info=False;User ID=test;Password=abc1234!;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            //TODO: Uncomment this line once you have your connection string
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

            //TODO: Uncomment these lines once you have added Identity to your project
            ////NOTE: This is where you would change your password requirements
            services.AddIdentity<AppUser, IdentityRole>(opts => {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

            // for sending the emails
            //services.AddTransient<IRazorViewToStringRenderer, RazorViewToStringRenderer>();
        }

        public void Configure(IApplicationBuilder app, IServiceProvider service)
        {
            //These lines allow you to see more detailed error messages
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();

            //This line allows you to use static pages like style sheets and images
            app.UseStaticFiles();

            //This marks the position in the middleware pipeline where a routing decision
            //is made for a URL.
            app.UseRouting();

            //This allows the data annotations for currency to work on Macs
            app.Use(async (context, next) =>
            {
                CultureInfo.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;

                await next.Invoke();
            });

            //TODO: Once you have added Identity into your project, you will need to uncomment this line
            app.UseAuthentication();
            app.UseAuthorization();

            //This method maps the controllers and their actions to a patter for
            //requests that's known as the default route. This route identifies
            //the Home controller as the default controller and the Index() action
            //method as the default action. The default route also identifies a 
            //third segment of the URL that's a parameter named id.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //Only need to seed ONCE. Do this at the beginning of the project.
            //Seeding.SeedIdentity.AddAdmin(service).Wait();
            //Seeding.SeedEmployee.SeedEmployees(service).Wait();
            //Seeding.SeedCustomer.SeedCustomers(service).Wait();
            //Then seed, in order, genre, prices, movies, movie schedule
        }
    }
   

}