using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;

// THIS SEEDS THE ROLES & ADDS THE FIRST MANAGEER!

namespace FinalProjectWorkspace.Seeding
{
    //add identity data
    public static class SeedIdentity
    {
        public static async Task AddAdmin(IServiceProvider serviceProvider)
        {
            //Get instances of the services needed to add a user & add a user to a role
            AppDbContext _context = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //TODO: Add the needed roles
            //if the manager role doesn't exist, add it
            if (await _roleManager.RoleExistsAsync("Manager") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Manager"));
            }

            //if the employee role doesn't exist, add it
            if (await _roleManager.RoleExistsAsync("Employee") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Employee"));
            }

            //if the customer role doesn't exist, add it
            if (await _roleManager.RoleExistsAsync("Customer") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Customer"));
            }

            //check to see if the manager has already been added
            AppUser newUser = _context.Users.FirstOrDefault(u => u.Email == "manager@mainstreetmovies.com");

            //if manager hasn't been created, then add them
            if (newUser == null)
            {
                //create a new instance of the app user class
                newUser = new AppUser();

                //populate the user properties that are from the 
                //IdentityUser base class
                newUser.UserName = "manager@mainstreetmovies.com";
                newUser.Email = "manager@mainstreetmovies.com";
                newUser.PhoneNumber = "(512)555-1234";

                //FirstName is included as an example, add any other fields they may need
                newUser.FirstName = "Manager";
                newUser.MiddleInitial = "M";
                newUser.LastName = "Manager";
                newUser.Address = "123 Manager St.";
                newUser.City = "Manager";
                newUser.State = "MA";
                newUser.Zip = "12345";
                newUser.Birthday = new DateTime(2000,12,25);
                newUser.PCPBalance = 1000;

                //create a variable for result
                IdentityResult result = new IdentityResult();
                try
                {
                    //NOTE: Attempt to add the user using the UserManager
                    //"Abc123!" is the password for this user
                    result = await _userManager.CreateAsync(newUser, "Abc123!");
                }
                catch (Exception ex)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.Append("There was an error adding the user with the email ");
                    msg.Append(newUser.Email);
                    msg.Append(". This often happens because you are missing a required field on AppUser");
                    throw new Exception(msg.ToString(), ex);
                }
                //if the user was not added succesfully, throw an exception
                //so the user knows what happened
                if (result.Succeeded == false)
                {
                    //Create a new string builder object to hold the error message(s)
                    StringBuilder msg = new StringBuilder();

                    //loop through all of the errors and add them to the message
                    foreach (var error in result.Errors)
                    {
                        msg.AppendLine(error.ToString());
                    }
                    
                    //throw a new exception to tell the user something is wrong
                    throw new Exception("This user can't be added:" + msg.ToString());
                }
                _context.SaveChanges();
                newUser = _context.Users.FirstOrDefault(u => u.UserName == "manager@mainstreetmovies.com");
            }

            //Add the new user we just created to the Manager role
            if (await _userManager.IsInRoleAsync(newUser, "Manager") == false)
            {
                await _userManager.AddToRoleAsync(newUser, "Manager");
            }

            //save changes
            _context.SaveChanges();
        }

    }
}