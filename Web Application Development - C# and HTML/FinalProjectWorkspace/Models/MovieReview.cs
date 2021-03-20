using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public class MovieReview
    {
        public Int32 MovieReviewID { get; set; }

        [Display(Name = "Review Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ReviewDate { get; set; }

        [Display(Name = "Approval Status")]
        public Boolean ApprovalStatus { get; set; }

        [Range(1,5)]
        public Int32? Rating { get; set; }

        [MaxLength(280)]
        [Display(Name = "Review Description")]
        public String ReviewDescription { get; set; }

        public Movie Movie { get; set; }
        public AppUser User { get; set; }
    }
}
