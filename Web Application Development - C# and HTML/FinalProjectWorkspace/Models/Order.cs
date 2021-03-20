using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{

    public class Order
    {
        private const Decimal SALES_TAX_RATE = 0.0825m; //Verify this is tax rate

        public Int32 OrderID { get; set; }

        [Display(Name ="Transaction Number")]
        public Int32 TransactionNumber { get; set; } //Will we need this?

        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Order Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderSubtotal
        {
            get { return Tickets.Sum(t => t.TotalCost); } //** We have to take off discount amount? 
        }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Taxes
        {
            get { return OrderSubtotal * SALES_TAX_RATE; }
        }

        [DisplayFormat(DataFormatString = "{0:C}")]
        [Display(Name = "Order Total")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + Taxes; }
        }

        [Display(Name = "Status")]
        public String OrderStatus { get; set; } //Active or inactive in case it was cancelled

        [Display(Name = "Popcorn Points")]
        public Int32 PopcornPoints { get; set; }

        [Display(Name ="Paid with Popcorn Points?")]
        public Boolean PaidWithPopcornPoints { get; set; }

        public List<Ticket> Tickets { get; set; }

        public AppUser Purchaser { get; set; } //Customer that purchased

        public AppUser Recipient { get; set; } //Recipient of gift, if there is one

        public AppUser Seller { get; set; } //Employee/Manager that sold order

        public Order()
        {
            if (Tickets == null)
            {
                Tickets = new List<Ticket>();
            }
        }

        

    }
}
