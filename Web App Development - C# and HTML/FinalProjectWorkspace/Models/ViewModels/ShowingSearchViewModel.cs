using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public enum AllTheatres
    {
        All,
        Theatre1,
        Theatre2
    }
    public class ShowingSearchViewModel
    {
        [Display(Name = "Select Day to Publish:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedShowingDate { get; set; } //Date selector

        [Display(Name = "Select a Friday to View The Schedule For That Week:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedFirstScheduleDay { get; set; } //Date selector

        [Display(Name = "Select Theatre:")]
        public Theatre SelectedTheatre { get; set; } //Enum

    }
}
