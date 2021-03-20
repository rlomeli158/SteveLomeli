using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using Microsoft.AspNetCore.Authorization;

namespace FinalProjectWorkspace.Controllers
{
    [Authorize]
    public class MovieReviewController : Controller
    {
        private readonly AppDbContext _context;

        public MovieReviewController(AppDbContext context)
        {
            _context = context;
        }

        // GET: MovieReview
        public IActionResult Index(int movieID)
        {
            if (movieID == 0)
            { 
                List<MovieReview> MovieReviews = new List<MovieReview>();
                if (User.IsInRole("Manager") || User.IsInRole("Employee"))
                {
                    MovieReviews = _context.MovieReview
                                    .Include(mr => mr.User)
                                    .Include(mr => mr.Movie)
                                    .ToList();
                }
                else //user is a customer
                {
                    MovieReviews = _context.MovieReview
                                    .Include(mr => mr.User)
                                    .Include(mr => mr.Movie)
                                    .Where(mr => mr.User.UserName == User.Identity.Name)
                                    .ToList();
                }
                return View(MovieReviews);
                
             
            }
            else
            {
                List<MovieReview> mrs = _context.MovieReview
                                          .Include(mr => mr.User)
                                          .Include(mr => mr.Movie)
                                          .Where(mr => mr.Movie.MovieID == movieID)
                                          .Where(mr => mr.ApprovalStatus == true)
                                          .ToList();
                return View(mrs);
            }
            
            }

        // GET: MovieReview/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("Error2", new String[] { "Could not find this movie review. Please Try Again." });
            }

            MovieReview movieReview = await _context.MovieReview
                                              .Include(mr => mr.Movie)
                                              .Include(mr => mr.User)
                                              .FirstOrDefaultAsync(m => m.MovieReviewID == id);
            if (movieReview == null)
            {
                return View("Error2", new String[] { "Could not find this movie review. Please Try Again." });
            }

            return View(movieReview);
        }

        // GET: MovieReview/Create
        [Authorize(Roles = "Customer")]
        public IActionResult Create(int? movieid)
        {
            
            if (movieid != null)
            {
                Movie movie = _context.Movies.Find(movieid);
                var query = from m in _context.MovieReview select m;
                query = query.Where(m => m.Movie.MovieID == movieid);
                List<MovieReview> movieReviews = query.Include(m => m.Movie).ToList();
                if (movieReviews.Any())
                {
                    return View("Error", new string[] { "You have already reviewed this movie!" });
                }

                IList<Movie> movieList = new List<Movie>()
                    {
                        new Movie() { MovieID=movie.MovieID, Title=movie.Title }
                    };
                SelectList slMovies = new SelectList(movieList, nameof(Movie.MovieID), nameof(Movie.Title));
                ViewBag.AllMovies = slMovies;
                return View();

            }
            ViewBag.AllMovies = GetTicketMovies();
            return View();
        }

        // POST: MovieReview/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Customer")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieReviewID,ReviewDate,ApprovalStatus,Rating,ReviewDescription")] MovieReview movieReview, int SelectedMovie)
        {
            if (ModelState.IsValid)
            {
                Movie dbMovie = _context.Movies.Find(SelectedMovie);

                movieReview.Movie = dbMovie;

                movieReview.ReviewDate = DateTime.Now;
                movieReview.ApprovalStatus = false;

                movieReview.User = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

                _context.Add(movieReview);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "MovieReview", new { id = movieReview.MovieReviewID });
            }
            ViewBag.AllMovies = GetTicketMovies();
            return View(movieReview);
        }

        // GET: MovieReview/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("Error2", new String[] { "Could not find this movie review. Please Try Again." });
            }
            

            MovieReview movieReview = _context.MovieReview
                                       .Include(mr => mr.Movie)
                                       .Include(mr => mr.User)
                                       .FirstOrDefault(o => o.MovieReviewID == id);
            if (movieReview == null)
            {
                return View("Error2", new String[] { "Could not find this movie review. Please Try Again." });
            }
            if (User.IsInRole("Manager") == false && User.IsInRole("Employee") == false && movieReview.User.UserName != User.Identity.Name)
            {
                return View("Error", new string[] { "You are not authorized to edit this order!" });
            }

            ViewBag.AllMovies = GetTicketMovies();
            return View(movieReview);
        }

        // POST: MovieReview/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovieReviewID,ReviewDate,ApprovalStatus,Rating,ReviewDescription")] MovieReview movieReview)
        {
            if (id != movieReview.MovieReviewID)
            {
                return View("Error2", new String[] { "Could not find this movie review. Please Try Again." });
            }

            if (ModelState.IsValid)
            {
                MovieReview dbMR = _context.MovieReview.Find(movieReview.MovieReviewID);
                try
                {
                    dbMR = _context.MovieReview
                      .Include(mr => mr.Movie)
                      .Include(mr => mr.User)
                      .FirstOrDefault(mr => mr.MovieReviewID == movieReview.MovieReviewID);

                    //update the scalar properties
                    if (User.IsInRole("Customer"))
                    {
                        dbMR.ApprovalStatus = false;
                    }
                    else
                    {
                        dbMR.ApprovalStatus = movieReview.ApprovalStatus;
                    }

                    if (User.IsInRole("Customer"))
                    {
                        dbMR.Rating = movieReview.Rating;
                    }
                    
                    dbMR.ReviewDescription = movieReview.ReviewDescription;

                    _context.Update(dbMR);
                    await _context.SaveChangesAsync();

                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieReviewExists(movieReview.MovieReviewID))
                    {
                        return View("Error2", new String[] { "Could not find this movie review. Please Try Again." });
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.AllMovies = GetTicketMovies();
            return View(movieReview);
        }

        

        private bool MovieReviewExists(int id)
        {
            return _context.MovieReview.Any(e => e.MovieReviewID == id);
        }
        private SelectList GetTicketMovies()
        {
            //create a list for all the courses
            List<Movie> ticketMovies = _context.Movies.Include(mr => mr.MovieReviews).ThenInclude(mr => mr.User).ThenInclude(mr => mr.Orders).ToList();

            //the user MUST select a course, so you don't need a dummy option for no course

            //use the constructor on select list to create a new select list with the options
            SelectList slTicketMovies = new SelectList(ticketMovies, nameof(Movie.MovieID), nameof(Movie.Title));

            return slTicketMovies;
        }
    }
}
