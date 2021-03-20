using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public enum Theatre
    {
        [Display(Name = "Theatre 1")]
        Theatre1,
        [Display(Name = "Theatre 2")]
        Theatre2
    }

    public class Showing
    {
        public Int32 ShowingID { get; set; }

        [Display(Name = "Showing Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ShowingDate { get; set; }

        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:h:mm tt}")]
        public DateTime StartTime { get; set; }

        [Display(Name = "End Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:h:mm tt}")]
        //[DisplayFormat(DataFormatString = "{0:hh:mm}")]
        public DateTime EndTime { get; set; }

        [Display(Name = "Theatre")]
        public Theatre Theatre { get; set; }

        [NotMapped]
        [Display(Name = "Seats Available")]
        public List<string> SeatsAvailable { get; set; }

        //[Display(Name = "Seats Available")]
        //public Int32 SeatsAvailable { get; set; } // You take the difference of all seats and seats purchased

        [Display(Name = "Special Event?")]
        public Boolean SpecialEvent { get; set; }

        [Display(Name = "Showing Status")]
        public String Status { get; set; }

        public Movie Movie { get; set; }
        public List<Ticket> Tickets { get; set; }

        public Showing()
        {
            if (Tickets == null)
            {
                Tickets = new List<Ticket>();
            }

        }
    }

}
