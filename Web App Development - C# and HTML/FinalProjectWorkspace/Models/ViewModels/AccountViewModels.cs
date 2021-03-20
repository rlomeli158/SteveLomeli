using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

//TODO: Change this namespace to match your project
namespace FinalProjectWorkspace.Models
{ 
    //NOTE: This is the view model used to allow the user to login
    //The user only needs teh email and password to login
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class MinAge : ValidationAttribute
    {
        private int _Limit;
        public MinAge(int Limit)
        { // The constructor which we use in modal.
            this._Limit = Limit;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime bday = DateTime.Parse(value.ToString());
            DateTime today = DateTime.Today;
            int age = today.Year - bday.Year;
            if (bday > today.AddYears(-age))
            {
                age--;
            }
            if (age < _Limit)
            {
                var result = new ValidationResult("Sorry you must be 13 or older to register");
                return result;
            }


            return null;

        }
    }

    //NOTE: This is the view model used to register a user
    //When the user registers, they only need to specify the
    //properties listed in this model
    public class RegisterViewModel
    {   
        //NOTE: Here is the property for email
        [Required(ErrorMessage = "Please enter your address!")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //NOTE: Here is the property for phone number
        [Required(ErrorMessage = "Please enter your phone number!")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }


        //TODO: Add any fields that you need for creating a new user
        //First name is provided as an example
        [Required(ErrorMessage = "Please enter your first name!")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Display(Name = "Middle Initial")]
        public String MiddleInitial { get; set; }

        [Required(ErrorMessage = "Please enter your last name!")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Display(Name = "Enter Address")]
        [Required(ErrorMessage = "Please enter your address!")]
        public String Address { get; set; }

        [Display(Name = "Enter City")]
        [Required(ErrorMessage = "Please enter your city!")]
        public String City { get; set; }

        [Display(Name = "Enter State")]
        [Required(ErrorMessage = "Please enter your state!")]
        public String State { get; set; }

        [Display(Name = "Enter Zip")]
        [Required(ErrorMessage = "Please enter your Zip!")]
        public String Zip { get; set; }

        [Display(Name = "Enter Birthday")]
        [Required(ErrorMessage = "Please enter your birthday!")]
        //[MinAge(13)] // 13 is the parameter of constructor. 
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Popcorn Point Balance")]
        public Int32 PCPBalance { get; set; }

        //NOTE: Here is the logic for putting in a password
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Account State")]
        public bool AccountStatus { get; set; }

        [Display(Name = "Account Type")]
        public bool EmployeeAccountType { get; set; }

        [Display(Name = "Account Type")]
        public bool CustomerAccountType { get; set; }
    }

    //NOTE: This is the view model used to allow the user to 
    //change their password
    public class ChangePasswordViewModel
    {
        public String UserID { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }   

    //NOTE: This is the view model used to display basic user information
    //on the index page
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        [Display(Name = "Phone Number")]
        public String PhoneNumber { get; set; }
        public String UserID { get; set; }
        [Display(Name = "First Name")]
        public String FirstName { get; set; }
        [Display(Name = "Middle Initial")]
        public String MiddleInitial { get; set; }
        [Display(Name = "Last Name")]
        public String LastName { get; set; }
        public String Address { get; set;}
        public String City { get; set; }
        public String State { get; set; }
        public String Zip { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Popcorn Points Balance")]
        public Int32 PCPBalance { get; set; }

        [Display(Name = "Account State")]
        public bool AccountStatus { get; set; }
    }

    public class EditViewModel
    {
        public String UserID { get; set; }
        //NOTE: Here is the property for email
        [Required(ErrorMessage = "Please enter your address!")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //NOTE: Here is the property for phone number
        [Required(ErrorMessage = "Please enter your phone number!")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }


        //TODO: Add any fields that you need for creating a new user
        //First name is provided as an example
        [Required(ErrorMessage = "Please enter your first name!")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your middle initial!")]
        [Display(Name = "Middle Initial")]
        public String MiddleInitial { get; set; }

        [Required(ErrorMessage = "Please enter your last name!")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Display(Name = "Enter Address")]
        [Required(ErrorMessage = "Please enter your address!")]
        public String Address { get; set; }

        [Display(Name = "Enter City")]
        [Required(ErrorMessage = "Please enter your city!")]
        public String City { get; set; }

        [Display(Name = "Enter State")]
        [Required(ErrorMessage = "Please enter your state!")]
        public String State { get; set; }

        [Display(Name = "Enter Zip")]
        [Required(ErrorMessage = "Please enter your Zip!")]
        public String Zip { get; set; }

        [Display(Name = "Enter Birthday")]
        [Required(ErrorMessage = "Please enter your birthday!")]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Account State")]
        public bool AccountStatus { get; set; }

        [Display(Name = "Popcorn Point Balance")]
        public Int32 PCPBalance { get; set; }

        //NOTE: Here is the logic for putting in a password
        //[Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}
