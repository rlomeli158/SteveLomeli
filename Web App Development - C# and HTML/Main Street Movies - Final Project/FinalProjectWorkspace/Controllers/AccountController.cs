using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

//TODO: Change this using statement to match your project
using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using Microsoft.EntityFrameworkCore;

//TODO: Change this namespace to match your project
namespace FinalProjectWorkspace.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> _userManager;
        private PasswordValidator<AppUser> _passwordValidator;
        private AppDbContext _context;

        public AccountController(AppDbContext appDbContext, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _context = appDbContext;
            _userManager = userManager;
            _signInManager = signIn;
            //user manager only has one password validator
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }

        // GET: /Account/Register
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel rvm)
        {
            if(rvm.Birthday.AddYears(13) >= DateTime.Now && rvm.EmployeeAccountType != true)
            {
                ModelState.AddModelError("", "You are too young to have an account. You must be at least 13 to register for this site.");
            }
            else if (rvm.Birthday.AddYears(18) >= DateTime.Now && rvm.EmployeeAccountType == true)
            {
                ModelState.AddModelError("", "The user is too young to be an employee. They must be at least 18 or older.");
            }

            var emailPassword = rvm.Password;

            //if registration data is valid, create a new user on the database
            if (ModelState.IsValid)
            {
                //this code maps the RegisterViewModel to the AppUser domain model
                AppUser newUser = new AppUser
                {
                    UserName = rvm.Email,
                    Email = rvm.Email,
                    PhoneNumber = rvm.PhoneNumber,

                    //TODO: Add the rest of the custom user fields here
                    //FirstName is included as an example
                    FirstName = rvm.FirstName,
                    MiddleInitial = rvm.MiddleInitial,
                    LastName = rvm.LastName,
                    Address = rvm.FirstName,
                    City = rvm.City,
                    State = rvm.State,
                    Zip = rvm.Zip,
                    Birthday = rvm.Birthday,
                    PCPBalance = rvm.PCPBalance,
                    AccountStatus = true,
                };

                //This code uses the UserManager object to create a new user with the specified password
                IdentityResult result = await _userManager.CreateAsync(newUser, rvm.Password);

                //If the add user operation was successful, we need to do a few more things
                if (result.Succeeded && User.IsInRole("Manager"))
                {
                    if (rvm.CustomerAccountType == false && rvm.EmployeeAccountType == true)
                    {
                        //adds to employee role
                        await _userManager.AddToRoleAsync(newUser, "Employee");
                    } else
                    {
                        //adds to customer role
                        await _userManager.AddToRoleAsync(newUser, "Customer");
                    }
                    

                    //NOTE: This code logs the user into the account that they just created
                    //You may or may not want to log a user in directly after they register - check
                    //the business rules!
                    //Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, lockoutOnFailure: false);

                    //Send the user to the home page
                    return RedirectToAction("AccountCreation", "Email", new { newUser.Id, emailPassword });
                }

                if (result.Succeeded != User.IsInRole("Manager"))
                {
                    //TODO: Add user to desired role. This example adds the user to the customer role
                    await _userManager.AddToRoleAsync(newUser, "Customer");

                    //NOTE: This code logs the user into the account that they just created
                    //You may or may not want to log a user in directly after they register - check
                    //the business rules!
                    Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, lockoutOnFailure: false);

                    //Send the user to the home page
                    return RedirectToAction("AccountCreation", "Email", new { newUser.Id, emailPassword } );
                }

                else  //the add user operation didn't work, and we need to show an error message
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            //this is the sad path - something went wrong, 
            //return the user to the register page to try again
            return View(rvm);
        }

        // GET: /Account/Login
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            if (User.Identity.IsAuthenticated) //user has been redirected here from a page they're not authorized to see
            {
                return View("Error", new string[] { "Access Denied" });
            }
            _signInManager.SignOutAsync(); //this removes any old cookies hanging around
            ViewBag.ReturnUrl = returnUrl; //pass along the page the user should go back to
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel lvm, string returnUrl)
        {
            //if user forgot to include user name or password,
            //send them back to the login page to try again
            if (ModelState.IsValid == false)
            {
                return View(lvm);
            }

            //attempt to sign the user in using the SignInManager
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, lvm.RememberMe, lockoutOnFailure: false);

            

            if (result.Succeeded)
            {
                
                AppUser userLoggedIn = _context.Users.FirstOrDefault(u => u.Email == lvm.Email);

                if (await _userManager.IsInRoleAsync(userLoggedIn, "Manager") && userLoggedIn.AccountStatus == true)
                {
                    return RedirectToAction("ManagerHomeView", "Home");
                }

                else if (await _userManager.IsInRoleAsync(userLoggedIn, "Employee") && userLoggedIn.AccountStatus == true)
                {
                    return RedirectToAction("EmployeeHomeView", "Home");
                }
                else if (await _userManager.IsInRoleAsync(userLoggedIn, "Manager") && userLoggedIn.AccountStatus == false)
                {
                    //return ?? "/" means if returnUrl is null, substitute "/" (home)
                    await _signInManager.SignOutAsync();
                    ModelState.AddModelError("", "Access is denied.");
                    //send user back to login page to try again
                    return View(lvm);
                }
                else if (await _userManager.IsInRoleAsync(userLoggedIn, "Employee") && userLoggedIn.AccountStatus == false)
                {
                    //return ?? "/" means if returnUrl is null, substitute "/" (home)
                    await _signInManager.SignOutAsync();
                    ModelState.AddModelError("", "Access is denied.");
                    //send user back to login page to try again
                    return View(lvm);
                }

                else if (await _userManager.IsInRoleAsync(userLoggedIn, "Customer") && userLoggedIn.AccountStatus == true)
                {
                    //return ?? "/" means if returnUrl is null, substitute "/" (home)
                    return RedirectToAction("Index", "Home");
                }

                else if (await _userManager.IsInRoleAsync(userLoggedIn, "Customer") && userLoggedIn.AccountStatus == false)
                {
                    //return ?? "/" means if returnUrl is null, substitute "/" (home)
                    await _signInManager.SignOutAsync();
                    ModelState.AddModelError("", "Access is denied.");
                    //send user back to login page to try again
                    return View(lvm);
                    

                }

            }

            //log in was not successful

            //add an error to the model to show invalid attempt
            ModelState.AddModelError("", "Invalid login attempt.");
            await _signInManager.SignOutAsync();
            //send user back to login page to try again
            return View(lvm);


        }
                   

        //GET: Account/Index
        public IActionResult Index(String id)
        {
            IndexViewModel ivm = new IndexViewModel();

            AppUser user;

            //get user info
            if (id != null) //(id != null)
            {
                user = _context.Users.FirstOrDefault(u => u.Id == id);
                //id = User.Identity.Name;
                //user = _context.Users.FirstOrDefault(u => u.UserName == id);
            }
            else //if 
            {
                id = User.Identity.Name;
                user = _context.Users.FirstOrDefault(u => u.UserName == id);
                //user = _context.Users.FirstOrDefault(u => u.Id == id);
            }
          


            //populate the view model
            //(i.e. map the domain model to the view model)
            ivm.Email = user.Email;
            ivm.HasPassword = true;
            ivm.UserID = user.Id;
            ivm.UserName = user.UserName;
            ivm.FirstName = user.FirstName;
            ivm.MiddleInitial = user.MiddleInitial;
            ivm.LastName = user.LastName;
            ivm.Address = user.Address;
            ivm.City = user.City;
            ivm.State = user.State;
            ivm.Zip = user.Zip;
            ivm.Birthday = user.Birthday;
            ivm.PhoneNumber = user.PhoneNumber;
            ivm.PCPBalance = user.PCPBalance;
            ivm.AccountStatus = user.AccountStatus;

            //send data to the view
            return View(ivm);
        }


        [Authorize]
        public IActionResult EditAccount(String id)
        {
            if (id == null)
            {
                return View("Error");
            }

            EditViewModel evm = new EditViewModel();

            //get user info
            //id = User.Identity.Name;
            //AppUser user = _context.Users.FindAsync(evm.UserID);
            AppUser user = _context.Users.FirstOrDefault(u => u.Id == id);

            //populate the view model
            //(i.e. map the domain model to the view model)
            evm.Email = user.UserName;
            evm.UserID = user.Id;
            evm.FirstName = user.FirstName;
            evm.MiddleInitial = user.MiddleInitial;
            evm.LastName = user.LastName;
            evm.Address = user.Address;
            evm.City = user.City;
            evm.State = user.State;
            evm.Zip = user.Zip;
            evm.Birthday = user.Birthday;
            evm.PhoneNumber = user.PhoneNumber;
            evm.PCPBalance = user.PCPBalance;
            evm.AccountStatus = user.AccountStatus;

            if (user == null)
            {
                return View("Error2", new String[] { "There was a problem editing this account. Please Try Again." });
            }
            return View(evm);

        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAccount(EditViewModel evm)
        {
            if (evm.UserID == null)
            {
                return View("Error");
            }

            //if (User.IsInRole("Manager") )


            if (ModelState.IsValid)
            {
                AppUser user = _context.Users.FirstOrDefault(u => u.Id == evm.UserID);

                user.Email = evm.Email;
                user.Id = evm.UserID;
                user.FirstName = evm.FirstName;
                user.MiddleInitial = evm.MiddleInitial;
                user.LastName = evm.LastName;
                user.Address = evm.Address;
                user.City = evm.City;
                user.State = evm.State;
                user.Zip = evm.Zip;
                user.Birthday = evm.Birthday;
                user.PhoneNumber = evm.PhoneNumber;
                user.PCPBalance = evm.PCPBalance;

                if (User.IsInRole("Employee") || User.IsInRole("Customer"))
                {
                    _ = user.AccountStatus == user.AccountStatus;
                }
                else
                {
                    user.AccountStatus = evm.AccountStatus;
                }
                

                await _userManager.UpdateAsync(user);
                await _context.SaveChangesAsync();


                return RedirectToAction("AccountUpdate", "Email", new { user.Id });

                //return RedirectToAction("Index", "Account", new { id = evm.UserID });
            }

            return View(evm);
        }

        /*
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAccount(String id, [Bind("FirstName,MiddleInitial,LastName,PhoneNumber,Address,City,State,Zip,Birthday")] AppUser appuser)
        {
            if (id == null)
            {
                return View("Error");
            }

            if (ModelState.IsValid)
            {
                try
                {


                    await _userManager.UpdateAsync(appuser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(appuser.Id))
                    {
                        return View("Error");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            
            return View(appuser);
        }
        */

        private bool UserExists(String id)
        {
            return _context.Users.Any(e => e.Id == id);
        }


        //Logic for change password
        // GET: /Account/ChangePassword
        public async Task<ActionResult> ChangePasswordAsync(String id)
        {
            AppUser userLoggedIn = await _userManager.FindByIdAsync(id);

            return View();
            /*
            if ((User.IsInRole("Manager") || User.IsInRole("Employee")) && userLoggedIn.UserName != User.Identity.Name)
            {
                return View();
            }
            else
            {
                return RedirectToAction("ChangePasswordEmpMan","Account", new { id });
            }
            */
        }

        public async Task<IActionResult> ChangePasswordEmpManAsync(String id)
        {
            AppUser userLoggedIn = await _userManager.FindByIdAsync(id);
            ChangePasswordViewModel cpvm = new ChangePasswordViewModel();
            cpvm.UserID = id;
            return View(cpvm);
        }

        // POST: /Account/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel cpvm, String id)
        {
            //if user forgot a field, send them back to 
            //change password page to try again
            if (ModelState.IsValid == false)
            {
                if (cpvm.UserID != null)
                {
                    //send the user back to the change password page to try again
                    return View("ChangePasswordEmpMan", cpvm);
                }
                else
                {
                    //send the user back to the change password page to try again
                    return View(cpvm);
                }
            }

            //Find the logged in user using the UserManager
            //AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUser userLoggedIn;
            if(cpvm.UserID != null)
            {
                userLoggedIn = await _userManager.FindByIdAsync(cpvm.UserID);
            }
            else
            {
                userLoggedIn = await _userManager.FindByIdAsync(id);
            }

            if ((User.IsInRole("Manager") || User.IsInRole("Employee")) && userLoggedIn.UserName != User.Identity.Name)
            {
                var resetpswd = await _userManager.GeneratePasswordResetTokenAsync(userLoggedIn);
                var outcome = await _userManager.ResetPasswordAsync(userLoggedIn, resetpswd, cpvm.NewPassword);

                if (outcome.Succeeded && User.IsInRole("Manager"))
                {
                    //sign in the user with the new password
                    //await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);

                    //send the user back to the home page
                    return RedirectToAction("ManagerHomeView", "Home");
                }
                else if (outcome.Succeeded && User.IsInRole("Employee"))
                {
                    //sign in the user with the new password
                    //await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);

                    //send the user back to the home page
                    return RedirectToAction("EmployeeHomeView", "Home");
                }
                else //attempt to change the password didn't work
                {
                    //Add all the errors from the result to the model state
                    foreach (var error in outcome.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    if (cpvm.UserID != null)
                    {
                        //send the user back to the change password page to try again
                        return View("ChangePasswordEmpMan", cpvm);
                    } else
                    {
                        //send the user back to the change password page to try again
                        return View(cpvm);
                    }
                    
                }


            }
           
            
             //Attempt to change the password using the UserManager
             var result = await _userManager.ChangePasswordAsync(userLoggedIn, cpvm.OldPassword, cpvm.NewPassword);
                
            //if the attempt to change the password worked
            if (result.Succeeded)
            {
                //sign in the user with the new password
                await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);

                //send the user back to the home page
                return RedirectToAction("AccountUpdate", "Email", new { userLoggedIn.Id });
                //return RedirectToAction("Index", "Account");
            }
            else //attempt to change the password didn't work
            {
                //Add all the errors from the result to the model state
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                if (cpvm.UserID != null)
                {
                    //send the user back to the change password page to try again
                    return View("ChangePasswordEmpMan", cpvm);
                }
                else
                {
                    //send the user back to the change password page to try again
                    return View(cpvm);
                }
            }
        }

        //GET:/Account/AccessDenied
        public IActionResult AccessDenied(String ReturnURL)
        {
            return View("Error", new string[] { "Access is denied" });
        }

        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogOff()
        {
            //sign the user out of the application
            _signInManager.SignOutAsync();

            //send the user back to the home page
            return RedirectToAction("Index", "Home");
        }           
    }
}