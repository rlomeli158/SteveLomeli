using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectWorkspace.Models
{
    public enum AllGenres
    {
        Action,
        Adventure,
        Animation,
        Comedy,
        Crime,
        Drama,
        Family,
        Fantasy,
        Horror,
        Musical,
        Romance,
        [Display(Name = "Science Fiction")]
        ScienceFiction,
        Thriller,
        War,
        Western

    }

    public enum AllMPAARatings
    {
        [Display(Name = "All MPAA Ratings")]
        All,
        G,
        PG,
        [Display(Name = "PG-13")]
        PG13,
        R,
        Unrated,
        [Display(Name = "NC-17")]
        NC17
    }

    public enum AllSearchTypes
    {
        [Display(Name = "Greater Than")]
        GreaterThan,
        [Display(Name = "Less Than")]
        LessThan,
        [Display(Name = "Before")]
        Before,
        [Display(Name = "After")]
        After
    }

    public class SearchViewModel
    {
        [Display(Name = "Search by Title:")]
        public String SelectedTitle { get; set; } //Textbox

        [Display(Name = "Search by Tagline:")]
        public String SelectedTagline { get; set; } //Textbox

        [Display(Name = "Search by Actor:")]
        public String SelectedActor { get; set; }

        [Display(Name = "Search by Genre:")]
        public Int32 SelectedGenreID { get; set; } //Dropdown

        [Display(Name = "Search by Year:")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter a valid year.")]
        public String SelectedYear { get; set; } //Textbox, verify it's a year (similar to salary) Should we use Int32 or String?

        [Display(Name = "Search by MPAA Rating:")]
        public Int32 SelectedMPAARating { get; set; } //Dropdown

        [Display(Name = "Search by Customer Rating:")]
        public String SelectedCustomerRating { get; set; } //Number Input

        [Display(Name = "Search Type:")]
        public AllSearchTypes SelectedSearchType { get; set; } //Radio Button

        [Display(Name = "Search by Showing Date:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedShowingDate { get; set; } //Date selector

        [Display(Name = "Enter a Starting Showing Date:")]
        [DataType(DataType.Date)]
        public DateTime? StartingShowingDate { get; set; } //Date selector

        [Display(Name = "Enter an Ending Showing Date:")]
        [DataType(DataType.Date)]
        public DateTime? EndingShowingDate { get; set; } //Date selector

    }
}