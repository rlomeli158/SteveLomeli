using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FinalProjectWorkspace.Models
{
    public class AppUser : IdentityUser
    {
        //User ID is inherited

        [Display(Name = "Enter user first name")]
        [Required(ErrorMessage ="Please enter your first name!")]
        public String FirstName { get; set; }

        [Display(Name = "Enter user a middle initial")]
        //[Required(ErrorMessage = "Please enter your middle initial!")]
        public String MiddleInitial { get; set; }

        [Display(Name = "Enter user last name")]
        [Required(ErrorMessage = "Please enter your last name!")]
        public String LastName { get; set; }

        //phone numebr is inherited

        [Display(Name = "Enter user address")]
        [Required(ErrorMessage = "Please enter your address!")]
        public String Address { get; set; }

        [Display(Name = "Enter user city")]
        [Required(ErrorMessage = "Please enter your city!")]
        public String City { get; set; }

        [Display(Name = "Enter user state")]
        [Required(ErrorMessage = "Please enter your state!")]
        public String State { get; set; }

        [Display(Name = "Enter user Zip")]
        [Required(ErrorMessage = "Please enter your Zip!")]
        public String Zip { get; set; }

        [Display(Name = "Enter user birthday")]
        [Required(ErrorMessage = "Please enter your birthday!")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }


        [Display(Name = "Account State")]
        public bool AccountStatus { get; set; }

        //do not store password since it is inherited

        [Display(Name = "Popcorn Point Balance")]
        public Int32 PCPBalance { get; set; }

        public List<Order> Orders { get; set; }
        public List<MovieReview> MovieReviews { get; set; }
        public List<Ticket> Tickets { get; set; }

        //Will show all of the orders someone has purchased
        [InverseProperty("Purchaser")]
        public List<Order> OrdersPurchased { get; set; }

        //Will show all of the orders someone has received
        [InverseProperty("Recipient")]
        public List<Order> OrdersReceived { get; set; }

        //Will show all of the orders someone has sold
        [InverseProperty("Seller")]
        public List<Order> OrdersSold { get; set; }

        public AppUser()
        {
            if (Tickets == null)
            {
                Tickets = new List<Ticket>();
            }

        }
    }
    
}
