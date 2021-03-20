using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public class CopyViewModel
    {
        [Display(Name = "Which date would you like to copy this schedule from?")]
        [Required(ErrorMessage = "Please select a date to copy from.")]
        [DataType(DataType.Date)]
        public DateTime? SelectedCopyDate { get; set; } //Date selector

        [Display(Name = "Select Theatre to Copy From:")]
        [Required(ErrorMessage = "Please select a theater's schedule to copy.")]
        public Theatre SelectedCopyTheatre { get; set; } //Enum

        [Display(Name = "Which date would you like to copy this schedule to?")]
        [Required(ErrorMessage = "Please select a date to copy to.")]
        [DataType(DataType.Date)]
        public DateTime? SelectedToDate { get; set; } //Date selector

        [Display(Name = "Select Theatre to Copy to:")]
        [Required(ErrorMessage = "Please select a theater's schedule to copy to.")]
        public Theatre SelectedToTheatre { get; set; } //Enum

    }
}
