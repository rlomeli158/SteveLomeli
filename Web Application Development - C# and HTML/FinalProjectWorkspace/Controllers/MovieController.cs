using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using System.Collections;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FinalProjectWorkspace.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;

        public MovieController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Browse()
        {

            //Populate view bag with list of categories
            ViewBag.AllGenres = GetAllGenres();
            ViewBag.AllMPAARatings = GetAllRatings();

            //Set default properties
            SearchViewModel svm = new SearchViewModel();
            //Are these here necessary?
            svm.SelectedGenreID = (int)AllGenres.Action;
            svm.SelectedSearchType = AllSearchTypes.GreaterThan;
            //svm.SelectedMPAARating = 2; //although it may not work

            return View(svm);
        }

        private SelectList GetAllGenres()
        {

            //Get the list of categories from the database
            List<Genre> genreList = _context.Genres.ToList();

            //add a dummy entry so the user can select all categories
            Genre SelectNone = new Genre() { GenreID = 0, GenreName = "All" };
            genreList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //CategoryID and CategoryName are the names of the properties on the Category class
            //CategoryID is the primary key
            SelectList genreSelectList = new SelectList(genreList.OrderBy(m => m.GenreID),
           "GenreID", "GenreName");

            //return the SelectList
            return genreSelectList;
        }

        private SelectList GetAllGenresWithID(int id)
        {

            //Get the list of categories from the database
            List<Genre> genreList = _context.Genres.ToList();

            Genre selectedGenre = _context.Genres.Find(id);

            //add a dummy entry so the user can select all categories
            Genre SelectNone = new Genre() { GenreID = 0, GenreName = "All" };
            genreList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //CategoryID and CategoryName are the names of the properties on the Category class
            //CategoryID is the primary key
            SelectList genreSelectList = new SelectList(genreList.OrderBy(m => m.GenreID),
           "GenreID", "GenreName", selectedGenre.GenreID);

            //return the SelectList
            return genreSelectList;
        }

        public List<string> GetSeatsAvailable(int showingID)
        {
            List<string> allSeats = new List<string>()
             {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5"
             };

            List<string> seatsTaken = _context.Ticket
                .Include(t => t.Order)
                .Include(t => t.Showing)
                .Where(t => t.Showing.ShowingID == showingID)
                .Where(t => t.Order.OrderStatus != "Cancelled")
                .Select(t => t.SeatNumber).ToList();

            List<string> seatsAvailable = allSeats.Except(seatsTaken).ToList();

            //Update the showing in the database
            Showing showing = _context.Showings.Where(s => s.ShowingID == showingID).First();
            showing.SeatsAvailable = seatsAvailable;
            _context.Update(showing);
            _context.SaveChanges();

            //SelectList slSeatsAvailable = new SelectList(seatsAvailable, nameof(Showing.ShowingID), nameof(Showing.StartTime));

            return seatsAvailable;
        }

        public SelectList GetAllRatings()
        {
            var MPAASelectList = new SelectList(Enum.GetValues(typeof(AllMPAARatings)).Cast<AllMPAARatings>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList(), "Value", "Text");

            return MPAASelectList;
        }

        public SelectList GetAllRatingsWithID(int id)
        {
            string MPAAStringToDisplay = Enum.GetName(typeof(AllMPAARatings), id);
            MPAARatings MPAARatingsToDisplay = (MPAARatings)Enum.Parse(typeof(MPAARatings), MPAAStringToDisplay);
            var MPAASelectList = new SelectList(Enum.GetValues(typeof(AllMPAARatings)).Cast<AllMPAARatings>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList(), "Value", "Text", ((int)MPAARatingsToDisplay+1));

            return MPAASelectList;
        }



        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            //Initial query LINQ
            var query = from m in _context.Movies select m;
            query = query.Include(m => m.MovieReviews);

            //If statements corresponding to each input form control

            if (svm.SelectedTitle != null && svm.SelectedTitle != "") //For title
            {
                query = query.Where(m => m.Title.Contains(svm.SelectedTitle.Trim()));
            }

            if (svm.SelectedTagline != null && svm.SelectedTagline != "") //For tagline
            {
                query = query.Where(m => m.Tagline.Contains(svm.SelectedTagline.Trim()));
            }

            if (svm.SelectedActor != null && svm.SelectedActor != "") //For actors
            {
                query = query.Where(m => m.Actors.Contains(svm.SelectedActor.Trim()));
            }

            if (svm.SelectedGenreID != 0) //For genre
            {
                Genre GenreToDisplay = _context.Genres.Find(svm.SelectedGenreID);
                query = query.Where(m => m.Genre == GenreToDisplay);
            }

            if (svm.SelectedMPAARating != 0) //For MPAARating
            {
                string MPAAStringToDisplay = Enum.GetName(typeof(AllMPAARatings), svm.SelectedMPAARating);
                MPAARatings MPAARatingsToDisplay = (MPAARatings)Enum.Parse(typeof(MPAARatings), MPAAStringToDisplay);
                //query = query.Where(m => m.MPAARating.ToString() == MPAARatingToDisplay.ToString());
                query = query.Where(m => m.MPAARating == MPAARatingsToDisplay);
            }

            if (svm.SelectedCustomerRating != null) //For rating 
            {
                if (Convert.ToDouble(svm.SelectedCustomerRating) > 5 || Convert.ToDouble(svm.SelectedCustomerRating) < 1)
                {
                    ModelState.AddModelError
                    ("IncorrectRating", "Rating must only be from 1 to 5. Please fix your rating");
                    //Populate view bag with list of categories
                    ViewBag.AllGenres = GetAllGenres();
                    ViewBag.AllMPAARatings = GetAllRatings();
                    return View("Browse", svm);
                }
              
                switch (svm.SelectedSearchType)
                {
                    case AllSearchTypes.GreaterThan:
                        query = query.Where(m => m.MovieReviews.Where(r => r.ApprovalStatus == true).Average(r => r.Rating) >= Convert.ToDouble(svm.SelectedCustomerRating));
                        break;
                    case AllSearchTypes.LessThan:
                        query = query.Where(m => m.MovieReviews.Where(r => r.ApprovalStatus == true).Average(r => r.Rating) <= Convert.ToDouble(svm.SelectedCustomerRating));
                        break;
                    default:
                        break;
                }
            }

            if (svm.SelectedYear != null) //For release year
            {
                //DateTime datSelectedDate = svm.SelectedYear ?? new DateTime(1900, 1, 1);
                query = query.Where(m => m.Year.Year == Convert.ToInt32(svm.SelectedYear));
            }

            if (svm.SelectedShowingDate != null)
            {
                DateTime datSelectedDate = svm.SelectedShowingDate ?? new DateTime(1900, 1, 1);
                var CurrentTime = DateTime.Now;
                query = query.Where(m => m.Showings.Where(m => m.StartTime > CurrentTime).Where(m => m.Status == "Published").Any(r => r.ShowingDate == datSelectedDate));
            }

            if(svm.StartingShowingDate != null && svm.EndingShowingDate == null)
            {
                ModelState.AddModelError
                    ("NotFilledOut", "Please fill out the corresponding ending date. If you want to only view one showing date, set that as your starting and ending date.");
                //Populate view bag with list of categories
                ViewBag.AllGenres = GetAllGenres();
                ViewBag.AllMPAARatings = GetAllRatings();
                return View("Browse", svm);
            }
            if (svm.StartingShowingDate == null && svm.EndingShowingDate != null)
            {
                ModelState.AddModelError
                    ("NotFilledOut", "Please fill out the corresponding starting date. If you want to only view one showing date, set that as your starting and ending date.");
                //Populate view bag with list of categories
                ViewBag.AllGenres = GetAllGenres();
                ViewBag.AllMPAARatings = GetAllRatings();
                return View("Browse",svm);
            }
            if (svm.StartingShowingDate > svm.EndingShowingDate && (svm.StartingShowingDate != null && svm.EndingShowingDate != null))
            {
                ModelState.AddModelError("WronglyFilled", "The starting date is after the end date. Please verify your dates.");
                //Populate view bag with list of categories
                ViewBag.AllGenres = GetAllGenres();
                ViewBag.AllMPAARatings = GetAllRatings();
                return View("Browse", svm);
            }

            if (svm.StartingShowingDate < DateTime.Now && (svm.StartingShowingDate != null && svm.EndingShowingDate != null))
            {
                ModelState.AddModelError("WronglyFilled", "You cannot search for past showtimes. Please verify your dates.");
                //Populate view bag with list of categories
                ViewBag.AllGenres = GetAllGenres();
                ViewBag.AllMPAARatings = GetAllRatings();
                return View("Browse", svm);
            }
            if (svm.StartingShowingDate != null && svm.EndingShowingDate != null)
            {
                DateTime datStartDate = svm.StartingShowingDate ?? new DateTime(1900, 1, 1);
                DateTime datEndDate = svm.EndingShowingDate ?? new DateTime(1900, 1, 1);
                var CurrentTime = DateTime.Now;
                query = query.Where(m => m.Showings.Where(m => m.StartTime > CurrentTime).Where(m => m.Status == "Published")
                .Any(r => svm.StartingShowingDate <= r.ShowingDate && svm.EndingShowingDate >= r.ShowingDate));
            }

            if (query != null) //they searched for something
            {
                TryValidateModel(svm);
                if (ModelState.IsValid == false)
                {
                    //re-populate ViewBag to have list of all categories & MPAA Ratings
                    ViewBag.AllGenres = GetAllGenres();
                    ViewBag.AllMPAARatings = GetAllRatings();

                    //View is returned with error messages
                    return View("Browse", svm);
                }

                //Execute query, include category with it

                List<Movie> SelectedMovies = query
                    .Include(m => m.Genre)
                    .Include(m => m.Showings)
                    .ThenInclude(m => m.Tickets)
                    .ToList();


                if (svm.StartingShowingDate != null && svm.EndingShowingDate != null) //For showing date ********
                {
                    DateTime startDate = svm.StartingShowingDate ?? new DateTime(1900, 1, 1);
                    DateTime endDate = svm.EndingShowingDate ?? new DateTime(1900, 1, 1);

                    ViewBag.startDate = startDate;
                    ViewBag.endDate = endDate;
                    foreach (Movie m in SelectedMovies)
                    {
                        foreach(Showing s in m.Showings)
                        {
                            if (svm.StartingShowingDate <= s.ShowingDate && svm.EndingShowingDate >= s.ShowingDate)
                            {
                                var seatsAvailable = GetSeatsAvailable(s.ShowingID);
                                s.SeatsAvailable = seatsAvailable;
                            }
                        }
                    }

                    //Populate the view bag with a count of all job postings
                    ViewBag.AllMovies = _context.Movies.Count();
                    //Populate the view bag with a count of selected job postings
                    ViewBag.SelectedMovies = SelectedMovies.Count();

                    return View("SearchResultsShowing", SelectedMovies.OrderBy(m => m.ShowingSortOrder).ThenBy(m => m.Title)); //Put year in here right now, but it should be showtime, right? **********


                }

                //Populate the view bag with a count of all job postings
                ViewBag.AllMovies = _context.Movies.Count();
                //Populate the view bag with a count of selected job postings
                ViewBag.SelectedMovies = SelectedMovies.Count();

                //return View("SearchResults", SelectedMovies.OrderBy(m => m.Showings.Min(s => s.StartTime))); //Put year in here right now, but it should be showtime, right? **********
                //return View("SearchResults", SelectedMovies.OrderBy(m => m.Title)); //Put year in here right now, but it should be showtime, right? **********
                return View("SearchResults", SelectedMovies.OrderBy(m => m.ShowingSortOrder).ThenBy(m => m.Title)); //Put year in here right now, but it should be showtime, right? **********
            }

            return View("Browse");

        }

        // GET: Movie
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movies.ToListAsync());
        }

        // GET: Movie/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("Error2", new String[] { "Could not find this movie. Please Try Again." });
            }

            var movie = await _context.Movies
                .Include(p => p.Showings)
                .Include(p => p.Genre)
                .Include(p => p.MovieReviews)
                .FirstOrDefaultAsync(m => m.MovieID == id);

            if (movie == null)
            {
                return View("Error2", new String[] { "Could not find this movie. Please Try Again." });
            }

            return View(movie);
        }

        // GET: Movie/Create
        [Authorize(Roles = "Manager")]
        public IActionResult Create()
        {
            ViewBag.AllGenres = GetAllGenres();
            ViewBag.AllMPAARatings = GetAllRatings();
            return View();
        }

        

        // POST: Movie/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Manager")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieID,MovieNumber,Title,Overview,Tagline,RunTime,Year,Genre,Revenue,Actors,MPAARating")] Movie movie, int SelectedGenre, int SelectedMPAARating)
        {

            if (SelectedGenre == 0 || SelectedMPAARating == 0 )
            {

                ModelState.AddModelError("DropdownError","Please verify that you have specified one Genre and one MPAA Rating.");

                ViewBag.AllGenres = GetAllGenres();
                ViewBag.AllMPAARatings = GetAllRatings();
                return View(movie);

            }

           

            if (ModelState.IsValid && SelectedGenre > 0 && SelectedMPAARating > 0 )
            {

                //Find the next Movie Number from the utilities class
                movie.MovieNumber = Utilities.GenerateNextMovieNumber.GetNextMovieNumber(_context);


                Genre dbGenre = _context.Genres.Find(SelectedGenre);

                movie.Genre = dbGenre;

                string MPAAStringToDisplay = Enum.GetName(typeof(AllMPAARatings), SelectedMPAARating);
                MPAARatings MPAARatingsToDisplay = (MPAARatings)Enum.Parse(typeof(MPAARatings), MPAAStringToDisplay);
                movie.MPAARating = MPAARatingsToDisplay;
               

                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            ViewBag.AllGenres = GetAllGenres();
            ViewBag.AllMPAARatings = GetAllRatings();

            
            return View(movie);

           

        }

        // GET: Movie/Edit/5
        [Authorize(Roles = "Manager")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("Error2", new String[] { "Could not find this movie. Please Try Again." });
            }

            Movie movie = _context.Movies.Include(m => m.Genre).First(m => m.MovieID == id);
            if (movie == null)
            {
                return View("Error2", new String[] { "Could not find this movie. Please Try Again." });
            }

            ViewBag.AllGenres = GetAllGenresWithID(movie.Genre.GenreID);
            Int32 movieRatingID =(int)movie.MPAARating + 1;
            ViewBag.AllMPAARatings = GetAllRatingsWithID(movieRatingID);
            return View(movie);
        }

        // POST: Movie/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Edit(int id, [Bind("MovieID,MovieNumber,Title,Overview,Tagline,RunTime,Year,Revenue,Actors,MPAARating")] Movie movie, int SelectedGenre, int SelectedMPAARating)
        {
            if (id != movie.MovieID)
            {
                return View("Error2", new String[] { "Could not find this movie. Please Try Again." });
            }


            if (SelectedGenre == 0 || SelectedMPAARating == 0)
            {

                ModelState.AddModelError("DropdownError", "Please verify that you have specified one Genre and one MPAA Rating.");

                ViewBag.AllGenres = GetAllGenres();
                ViewBag.AllMPAARatings = GetAllRatings();
                return View(movie);

            }

            if (ModelState.IsValid && SelectedGenre > 0 && SelectedMPAARating > 0)
            {
                try
                {
                    Genre dbGenre = _context.Genres.Find(SelectedGenre);

                    movie.Genre = dbGenre;

                    string MPAAStringToDisplay = Enum.GetName(typeof(AllMPAARatings), SelectedMPAARating);
                    MPAARatings MPAARatingsToDisplay = (MPAARatings)Enum.Parse(typeof(MPAARatings), MPAAStringToDisplay);
                    movie.MPAARating = MPAARatingsToDisplay;

                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.MovieID))
                    {
                        return View("Error2", new String[] { "Could not find this movie. Please Try Again." });
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.AllGenres = GetAllGenres();
            ViewBag.AllMPAARatings = GetAllRatings();
            return View(movie);
        }

        /*
        // GET: Movie/Delete/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.MovieID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Manager")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        */

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.MovieID == id);
        }
        
    }
}
