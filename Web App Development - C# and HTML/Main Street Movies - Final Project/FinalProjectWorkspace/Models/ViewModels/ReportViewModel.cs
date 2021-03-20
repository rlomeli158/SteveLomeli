using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectWorkspace.Models
{

    public class ReportViewModel
    {
        [Display(Name = "Total Seats Sold")]
        public Int32 TotalSeatsSold { get; set; }

        [Display(Name = "Total Revenue")]
        //[DisplayFormat(DataFormatString = "{0:C}")]
        [DataType(DataType.Currency)]
        public Decimal TotalRevenue { get; set; }

        [Display(Name = "Customer")]
        public List<AppUser> AppUsers { get; set; }

        [Display(Name = "Tickets")]
        public List<Ticket> Tickets { get; set; }

        [Display(Name = "Popcorn Point Tickets")]
        public List<Ticket> PopcornPointTickets { get; set; }

    }
    public class ReportSearchViewModel
    {
        [Display(Name = "Search by Starting Date:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedStartingDate { get; set; } 

        [Display(Name = "Search by Ending Date:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedEndingDate { get; set; } 

        [Display(Name = "Search by Movie:")]
        public Int32 SelectedMovie { get; set; }

        [Display(Name = "Search by MPAA Rating:")]
        public Int32 SelectedMPAARating { get; set; } 

        [Display(Name = "Search by Time:")]
        [DataType(DataType.Time)]
        public DateTime? SelectedTime { get; set; }

        [Display(Name = "Search Type:")]
        public AllSearchTypes SelectedSearchType { get; set; }

        [Display(Name = "See Total Seats Sold")]
        public Boolean TotalSeatsSold { get; set; }

        [Display(Name = "See Total Revenue")]
        public Boolean TotalRevenue { get; set; }

        [Display(Name = "See By Customers")]
        public Boolean ByCustomers { get; set; }

        [Display(Name = "See Popcorn Point Tickets")]
        public Boolean PPTickets { get; set; }

    }

}
