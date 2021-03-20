using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public enum DiscountNames
    {
        None,
        Matinee,
        Tuesday_Discount,
        Senior_Discounts,
        Tuesday_and_Senior,
        Matinee_and_Senior,
        Weekday_Discount
    }

    public enum TicketTypes
    {
        Weekday_Regular,
        Weekend_Regular,
        Special_Event
    }

    //Should be individual tickets
    public class Ticket
    {
        public Int32 TicketID { get; set; }

        [Display(Name = "Ticket Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TicketPrice { get; set; }

        [Display(Name = "Discount Name")]
        public DiscountNames DiscountName { get; set; }

        [Display(Name = "Ticket Type")]
        public TicketTypes TicketType { get; set; }

        [Display(Name = "Discount Amount")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal DiscountAmount { get; set; } 

        [DisplayFormat(DataFormatString = "{0:C}")]
        [Display(Name = "Ticket Cost")]
        public Decimal TotalCost { get; set; }

        //Seats purchased
        //[Required(ErrorMessage = "Please select a seat.")]
        [Display(Name = "Select Your Seat:")]
        public String SeatNumber { get; set; }

        [Display(Name = "Transaction Popcorn Points")]
        public Decimal TransactionPopcornPoints { get; set; }

        //to see if ticket is cancelled or not
        [Display(Name = "Ticket Status")]
        public String TicketStatus{ get; set; }

        public Order Order { get; set; }
        public Showing Showing { get; set; }


    }
}
