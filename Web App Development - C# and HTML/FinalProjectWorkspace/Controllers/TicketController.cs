using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using System.Globalization;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.AspNetCore.Identity;

namespace FinalProjectWorkspace.Controllers
{
    [Authorize]
    public class TicketController : Controller
    {
        private readonly AppDbContext _context;
        private UserManager<AppUser> _userManager;

        public TicketController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Ticket
        public IActionResult Index(int orderID)
        {
            //limit the list to only the registration details that belong to this registration
            List<Ticket> t = _context.Ticket
                                       .Include(rd => rd.Showing)
                                       .ThenInclude(rd => rd.Movie)
                                       .Include(rd => rd.Order)
                                       .Where(rd => rd.Order.OrderID == orderID)
                                       .ToList();

            return View(t);
        }

        public IActionResult ReportIndex()
        {
            
            return View();
        }

        public async Task<List<string>> GetSeatsAvailableAsync(int showingID)
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
            await _context.SaveChangesAsync();

            //SelectList slSeatsAvailable = new SelectList(seatsAvailable, nameof(Showing.ShowingID), nameof(Showing.StartTime));

            return seatsAvailable;
        }

        private SelectList GetAllShowings()
        {
            //create a list for all the courses
            List<Showing> allShowings = _context.Showings.Include(s => s.Movie).ToList();

            //the user MUST select a course, so you don't need a dummy option for no course

            //use the constructor on select list to create a new select list with the options
            SelectList slAllShowings = new SelectList(allShowings, nameof(Showing.ShowingID), nameof(Showing.StartTime));

            return slAllShowings;
        }

        private SelectList GetAllShowingsWithID(int showingID)
        {
            //create a list for all the courses
            List<Showing> allShowings = _context.Showings.Include(s => s.Movie).ToList();

            //All showings that match the showing ID passed in
            List<Showing> possibleShowings = _context.Showings.Where(sh => sh.ShowingID == showingID).ToList();

            //the user MUST select a course, so you don't need a dummy option for no course
            Int32 selectedShowingID = 0;

            foreach (Showing s in possibleShowings)
            {
                selectedShowingID = s.ShowingID;
            }

            //use the constructor on select list to create a new select list with the options
            SelectList slAllShowings = new SelectList(allShowings, nameof(Showing.ShowingID), nameof(Showing.StartTime), selectedShowingID);

            return slAllShowings;
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

        public SelectList GetAllMovies()
        {
            //Get the list of suppliers from the database
            List<Movie> movieList = _context.Movies.ToList();

            //add a dummy entry so the user can select all suppliers
            Movie SelectNone = new Movie() { MovieID = 0, Title = "Select A Movie" };
            movieList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //SupplierID and SupplierName are the names of the properties on the Supplier class
            //SupplierID is the primary key
            SelectList movieSelectList = new SelectList(movieList.OrderBy(s => s.MovieID), "MovieID", "Title");

            //return the MultiSelectList
            return movieSelectList;
        }

        // GET: Ticket/Create
        public async Task<IActionResult> CreateAsync(int orderID, int? showingID)
        {
            Showing showing = _context.Showings.Find(showingID);

            if (DateTime.Now > showing.StartTime)
            {
                return View("Error", new String[] { "This showing is in the past, you can't watch this anymore!" });
            }

            if(showing.Status == "Unpublished" || showing.Status == "Cancelled")
            {
                return View("Error", new String[] { "This showing is unpublished or cancelled!" });
            }
            //create a new instance of the RegistrationDetail class
            Ticket t = new Ticket();

            //find the order that should be associated with this ticket
            //Order dbOrder = _context.Order.Find(orderID);

            //Get tickets, showings, movies
            Order dbOrder = _context.Order.Include(o => o.Purchaser)
                                          .Include(o => o.Tickets)
                                          .ThenInclude(o => o.Showing)
                                          .ThenInclude(o => o.Movie)
                                          .FirstOrDefault(o => o.OrderID == orderID);

            //set the new registration detail's registration equal to the registration you just found
            t.Order = dbOrder;


            Showing selectedShowing = _context.Showings.Include(s => s.Movie)
                                                .FirstOrDefault(s => s.ShowingID == showingID);
            if (dbOrder.Tickets.Any())
            {
                foreach (Ticket ticket in dbOrder.Tickets)
                {
                    //If the showing time of the showing we're trying to add starts after the end time of the showing already on the order, it's good
                    //it's also okay if they add more of the same showing
                    if (selectedShowing.StartTime > ticket.Showing.EndTime || selectedShowing.ShowingID == ticket.Showing.ShowingID)
                    {
                        //it's good
                    }
                    //if it gets here, then the showing we're trying to add is before the showing already on the order.
                    //We have to make sure that if it's before, the selected showing we want to add ends before the start time of the showing already on there
                    //it's also okay if they add more of the same showing
                    else if (selectedShowing.EndTime < ticket.Showing.StartTime || selectedShowing.ShowingID == ticket.Showing.ShowingID)
                    {
                        //it's good
                    }
                    else
                    {
                        return View("Error", new String[]
                        { "This showing overlaps with a showing already on your order. Please delete " + ticket.Showing.Movie.Title + " to add this showing." });
                    }
                }
            }

            //The selected showing is already on the order
            if (dbOrder.Tickets.Any(t => t.Showing.Movie == selectedShowing.Movie))
            {
                //Finding all the tickets that have the same movie
                List<Ticket> ticketList = dbOrder.Tickets.Where(t => t.Showing.Movie == selectedShowing.Movie).ToList();

                //The order already contains tickets to this showing
                if (ticketList.Any(t => t.Showing.ShowingID != selectedShowing.ShowingID))
                {
                    //ModelState.AddModelError("TicketError", "There's already a ticket for a different showing on your order!");
                    //return View(ticket);
                    return View("Error", new String[] { "There's already a ticket for a different showing on your order!" });
                }

            }

            AppUser user = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            if (selectedShowing.Movie.MPAARating == MPAARatings.R || selectedShowing.Movie.MPAARating == MPAARatings.NC17)
            {
                if (user.Birthday.AddYears(18) >= DateTime.Now)
                {
                    return View("Error", new String[]
                    { "You are too young to see this movie. Please find another one!" });
                }
            }

            //it should always go to the else because they need to buy a ticket from a showing
            if (showingID == null)
            {
                //populate the ViewBag with a list of existing courses
                ViewBag.AllShowings = GetAllShowings();
                //ViewBag.AllSeatsAvailable = GetSeatsAvailable();
            }
            else
            {
                //populate the ViewBag with a list of existing courses
                ViewBag.AllShowings = GetAllShowingsWithID((int)showingID);
                ViewBag.AllSeatsAvailable = await GetSeatsAvailableAsync((int)showingID);
            }

            //pass the newly created registration detail to the view
            return View(t);
        }

        private Decimal GetPrice(Ticket ticketIn)
        {
            Ticket ticket = _context.Ticket
                                    .Include(rd => rd.Showing)
                                    .Include(rd => rd.Order)
                                    .ThenInclude(rd => rd.Purchaser)
                                    .FirstOrDefault(rd => rd.TicketID == ticketIn.TicketID);
            String showingDay;
            DateTime showingTime;

            Order order = _context.Order.FirstOrDefault();
            if (ticket != null)
            {
                order = _context.Order.Where(o => o.OrderID != ticket.Order.OrderID).FirstOrDefault();
            } else
            {
                order = _context.Order.Where(o => o.OrderID != ticketIn.Order.OrderID).FirstOrDefault();

            }
            Order badOrder = order;
            TimeSpan age;
            Decimal showingPrice = 0.00m;

            if (ticket == null)
            {
                //SPECIAL EVENT PRICING
                if (ticketIn.Showing.SpecialEvent == true)
                {
                    String price = _context.Prices
                    .Where(p => p.PriceName == "SPECIAL_EVENT_PRICE")
                    .Select(p => p.PriceAmount).First().ToString();

                    ticketIn.DiscountAmount = 0;
                    ticketIn.TicketType = TicketTypes.Special_Event;
                    return showingPrice = Decimal.Parse(price, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                }

                order = _context.Order.Find(ticketIn.Order.OrderID);

                order = _context.Order
                                .Include(o => o.Tickets).ThenInclude(o => o.Showing)
                                .Include(o => o.Purchaser)
                                .Where(o => o.OrderID == ticketIn.Order.OrderID)
                                .First();

                showingDay = ticketIn.Showing.ShowingDate.ToString("dddd");
                showingTime = ticketIn.Showing.StartTime;
                age = DateTime.Now - order.Purchaser.Birthday;

            }
            else
            {
                //SPECIAL EVENT PRICING
                if (ticket.Showing.SpecialEvent == true)
                {
                    String price = _context.Prices
                                        .Where(p => p.PriceName == "SPECIAL_EVENT_PRICE")
                                        .Select(p => p.PriceAmount).First().ToString();
                    ticketIn.DiscountAmount = 0;
                    ticketIn.TicketType = TicketTypes.Special_Event;
                    return showingPrice = Decimal.Parse(price, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                }
                showingDay = ticket.Showing.ShowingDate.ToString("dddd");
                showingTime = ticket.Showing.StartTime;
                age = DateTime.Now - ticket.Order.Purchaser.Birthday;

            }

            var weekDays = new List<string>()
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday"
            };

            //Important Times
            DateTime compareTimeNoon = new DateTime(showingTime.Year, showingTime.Month, showingTime.Day, 12, 00, 00);

            DateTime compareTimeFive = new DateTime(showingTime.Year, showingTime.Month, showingTime.Day, 17, 00, 00);

            //set the registration detail's price equal to the course price
            //this will allow us to to store the price that the user paid
            //TODO: Get ticket price from prices table
            if (weekDays.Contains(showingDay))
            {

                if (showingTime < compareTimeNoon)
                {
                    String price = _context.Prices
                                    .Where(p => p.PriceName == "MATINEE_PRICE")
                                    .Select(p => p.PriceAmount).First().ToString();

                    showingPrice = Decimal.Parse(price, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);

                    Decimal normalPrice;

                    if (showingDay != "Friday")
                    {
                        String normal = _context.Prices
                                            .Where(p => p.PriceName == "WEEKDAY_REGULAR_PRICE")
                                            .Select(p => p.PriceAmount).First().ToString();

                        normalPrice = Decimal.Parse(normal, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                        ticketIn.TicketType = TicketTypes.Weekend_Regular;

                    }
                    else
                    {
                        String normal = _context.Prices
                                            .Where(p => p.PriceName == "WEEKEND_REGULAR_PRICE")
                                            .Select(p => p.PriceAmount).First().ToString();

                        normalPrice = Decimal.Parse(normal, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);

                        ticketIn.TicketType = TicketTypes.Weekday_Regular;
                    }
                   
                    ticketIn.DiscountAmount = normalPrice - showingPrice;
                    ticketIn.DiscountName = DiscountNames.Matinee;
                }
                else if (showingDay == "Tuesday" && showingTime < compareTimeFive) //WORKS
                {
                    String price = _context.Prices
                                    .Where(p => p.PriceName == "DISCOUNT_TUESDAY_PRICE")
                                    .Select(p => p.PriceAmount).First().ToString();

                    showingPrice = Decimal.Parse(price, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);

                    String normal = _context.Prices
                                            .Where(p => p.PriceName == "WEEKDAY_REGULAR_PRICE")
                                            .Select(p => p.PriceAmount).First().ToString();

                    Decimal normalPrice = Decimal.Parse(normal, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);

                    ticketIn.TicketType = TicketTypes.Weekday_Regular;
                    ticketIn.DiscountAmount = normalPrice - showingPrice;
                    ticketIn.DiscountName = DiscountNames.Tuesday_Discount;

                }
                else if (showingDay != "Friday") //WORKS FOR WEEKDAYS AFTER 12, WORKS FOR TUESDAY AFTER 5
                {
                    String price = _context.Prices
                                    .Where(p => p.PriceName == "WEEKDAY_REGULAR_PRICE")
                                    .Select(p => p.PriceAmount).First().ToString();

                    showingPrice = Decimal.Parse(price, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                    ticketIn.TicketType = TicketTypes.Weekday_Regular;
                    ticketIn.DiscountName = DiscountNames.Weekday_Discount;

                }
                else if (showingTime > compareTimeNoon) //WORKS FOR FRIDAY
                {
                    String price = _context.Prices
                                    .Where(p => p.PriceName == "WEEKEND_REGULAR_PRICE")
                                    .Select(p => p.PriceAmount).First().ToString();

                    showingPrice = Decimal.Parse(price, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                    ticketIn.TicketType = TicketTypes.Weekend_Regular;

                }
            }
            else
            {
                String price = _context.Prices
                                                    .Where(p => p.PriceName == "WEEKEND_REGULAR_PRICE")
                                                    .Select(p => p.PriceAmount).First().ToString();

                showingPrice = Decimal.Parse(price, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
                ticketIn.TicketType = TicketTypes.Weekend_Regular;

            }

            //Age Discount
            Double ageInYears = age.TotalDays / 365;
            if (ageInYears >= 60)
            {
                if (order != badOrder)
                {
                    if (order.Tickets
                            .Where(t => t.DiscountName == DiscountNames.Senior_Discounts
                                       || t.DiscountName == DiscountNames.Matinee_and_Senior
                                       || t.DiscountName == DiscountNames.Tuesday_and_Senior).Count() >= 2 && ticket == null)
                    {
                        return showingPrice;
                    }
                }

                if (ticket != null)
                {
                    if (ticket.Order.Tickets.Where(t => t.DiscountName == DiscountNames.Senior_Discounts
                            || t.DiscountName == DiscountNames.Matinee_and_Senior
                            || t.DiscountName == DiscountNames.Tuesday_and_Senior).Count() >= 2)
                    {
                        return showingPrice;
                    }
                }
                String price = _context.Prices
                                    .Where(p => p.PriceName == "SENIOR_DISCOUNT")
                                    .Select(p => p.PriceAmount).First().ToString();
                Decimal seniorDiscount;
                seniorDiscount = Decimal.Parse(price, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);

                //Remove the senior discount price
                showingPrice -= seniorDiscount;
                ticketIn.DiscountAmount += seniorDiscount;

                if (ticketIn.DiscountName == DiscountNames.Matinee)
                {
                    ticketIn.DiscountName = DiscountNames.Matinee_and_Senior;
                }
                else if (ticketIn.DiscountName == DiscountNames.Tuesday_Discount)
                {
                    ticketIn.DiscountName = DiscountNames.Tuesday_and_Senior;
                } else
                {
                    ticketIn.DiscountName = DiscountNames.Senior_Discounts;
                }
            }

            return showingPrice;
        }

        // POST: Ticket/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Order, Users, User, Purchaser, TicketID, SeatNumber")] Ticket ticket, int SelectedShowing)
        {
            if (ticket.SeatNumber == null)
            {
                ModelState.AddModelError("EmptyError", "Please select a seat.");

                ViewBag.AllShowings = GetAllShowings();
                ViewBag.AllSeatsAvailable = await GetSeatsAvailableAsync(SelectedShowing);
                return View(ticket);
                //return View("Error", new String[] { "This seat is taken." });
            }

            //if user has not entered all fields, send them back to try again
            if (ModelState.IsValid == false)
            {
                ViewBag.AllShowings = GetAllShowings();
                return View(ticket);
            }

            //find the order on the database that has the correct order id
            //unfortunately, the HTTP request will not contain the entire order object, 
            //just the order id, so we have to find the actual object in the database
            //Order dbOrder = _context.Order.Find(ticket.Order.OrderID);

            //Get tickets, showings, movies
            Order dbOrder = _context.Order.Include(o => o.Purchaser)
                                          .Include(o => o.Tickets)
                                          .ThenInclude(o => o.Showing)
                                          .ThenInclude(o => o.Movie)
                                          .FirstOrDefault(o => o.OrderID == ticket.Order.OrderID);

            Showing selectedShowing = _context.Showings.Include(s => s.Movie)
                                                .FirstOrDefault(s => s.ShowingID == SelectedShowing);

            if (selectedShowing.Status == "Cancelled")
            {
                return View("Error", new String[] { "This showing has been cancelled!" });
            }

            //The selected showing is already on the order
            if (dbOrder.Tickets.Any(t => t.Showing.Movie == selectedShowing.Movie))
            {
                //Finding all the tickets that have the same movie
                List<Ticket> ticketList = dbOrder.Tickets.Where(t => t.Showing.Movie == selectedShowing.Movie).ToList();

                //The order already contains tickets to this showing
                if(ticketList.Any(t => t.Showing.ShowingID != selectedShowing.ShowingID))
                {
                    //ModelState.AddModelError("TicketError", "There's already a ticket for a different showing on your order!");
                    //return View(ticket);
                    return View("Error", new String[] { "There's already a ticket for a different showing on your order!" });
                }

            }

            List<string> seatsAvailable = await GetSeatsAvailableAsync(selectedShowing.ShowingID);
            if (!seatsAvailable.Contains(ticket.SeatNumber))
            {
                ModelState.AddModelError("TakenError", "This seat is taken.");

                ViewBag.AllShowings = GetAllShowings();
                ViewBag.AllSeatsAvailable = await GetSeatsAvailableAsync(SelectedShowing);
                return View(ticket);
                //return View("Error", new String[] { "This seat is taken." });
            }

            foreach (Ticket t in dbOrder.Tickets)
            {
                //If the showing time of the showing we're trying to add starts after the end time of the showing already on the order, it's good
                //it's also okay if they add more of the same showing
                if (selectedShowing.StartTime > t.Showing.EndTime || selectedShowing.ShowingID == t.Showing.ShowingID)
                {
                    //it's good
                }
                //if it gets here, then the showing we're trying to add is before the showing already on the order.
                //We have to make sure that if it's before, the selected showing we want to add ends before the start time of the showing already on there
                //it's also okay if they add more of the same showing
                else if (selectedShowing.EndTime < t.Showing.StartTime || selectedShowing.ShowingID == t.Showing.ShowingID)
                {
                    //it's good
                } else
                {
                    return View("Error", new String[]
                    { "This showing overlaps with a showing already on your order. Please delete " + t.Showing.Movie.Title + " to add this showing." });
                }
            }

            //Showings are good, add tickets
            ticket.Showing = selectedShowing;

            //set the registration on the registration detail equal to the registration that we just found
            ticket.Order = dbOrder;

            if (ticket.Showing.Movie.MPAARating == MPAARatings.R || ticket.Showing.Movie.MPAARating == MPAARatings.NC17)
            {
                if (ticket.Order.Purchaser.Birthday.AddYears(18) >= DateTime.Now)
                {
                    return View("Error", new String[]
                    { "You are too young to see this movie. Please find another one!" });
                }
            }

            //find the course to be associated with this order
            //Showing dbShowing = _context.Showings.Find(SelectedShowing);
            //TODO: Here is the code to count tickets
            //Int32 ticketCount = _context.Ticket.Include(t => t.Order).Where(t => t.Order.OrderID == ticket.Order.OrderID).Count();


            //Get prices depending on day and time
            ticket.DiscountAmount = 0;
            ticket.TotalCost = GetPrice(ticket);
            ticket.TicketPrice = ticket.TotalCost + ticket.DiscountAmount;

            //calculate the extended price for the registration detail
            //TODO: Calculate total cost by number of tickets * price per ticket?

            ticket.TransactionPopcornPoints = Math.Truncate(ticket.TotalCost);

            ticket.TicketStatus = "Active";

            //add the registration detail to the database
            _context.Add(ticket);
            await _context.SaveChangesAsync();

            //send the user to the details page for this registration
            return RedirectToAction("Details", "Order", new { id = ticket.Order.OrderID });
        }

        // GET: Ticket/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //user did not specify a registration detail to edit
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a ticket to edit!" });
            }

            //find the registration detail
            Ticket ticket = await _context.Ticket
                                          .Include(rd => rd.Showing)
                                          .Include(rd => rd.Order)
                                          .ThenInclude(rd => rd.Purchaser)
                                          .FirstOrDefaultAsync(rd => rd.TicketID == id);
            if (ticket == null)
            {
                return View("Error", new String[] { "This ticket's details were not found" });
            }
            return View(ticket);
        }

        // POST: Ticket/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Order, TicketID,TicketPrice,DiscountAmount,TotalCost,SeatNumber,TransactionPopcornPoints")] Ticket ticket)
        {
            //this is a security check to make sure they are editing the correct record
            if (id != ticket.TicketID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            //information is not valid, try again
            if (ModelState.IsValid == false)
            {
                return View(ticket);
            }

            //create a new registration detail
            Ticket dbT;
            //if code gets this far, update the record
            try
            {
                //find the existing registration detail in the database
                //include both registration and course
                dbT = _context.Ticket
                      .Include(rd => rd.Showing)
                      .Include(rd => rd.Order)
                      .ThenInclude(rd => rd.Purchaser)
                      .FirstOrDefault(rd => rd.TicketID == ticket.TicketID);

                //update the scalar properties

                //Get prices depending on day and time
                dbT.DiscountAmount = 0;
                dbT.TotalCost = GetPrice(ticket);
                dbT.DiscountAmount = ticket.DiscountAmount;
                dbT.TicketPrice = dbT.TotalCost + ticket.DiscountAmount;

                //dbT.Quantity = orderDetail.Quantity;

                List<string> seatsAvailable = await GetSeatsAvailableAsync(dbT.Showing.ShowingID);
                if (!seatsAvailable.Contains(ticket.SeatNumber))
                {
                    return View("Error", new String[] { "This seat is taken." });
                } 
                dbT.SeatNumber = ticket.SeatNumber;
                //dbT.ExtendedPrice = dbT.Quantity * dbT.ProductPrice;

                dbT.TransactionPopcornPoints = dbT.TicketPrice;


                //save changes
                _context.Update(dbT);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            //if code gets this far, go back to the registration details index page
            return RedirectToAction("Details", "Order", new { id = dbT.Order.OrderID });
        }

        // GET: Ticket/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify an order detail to delete!" });
            }

            Ticket ticket = await _context.Ticket
                .Include(r => r.Order)
                .FirstOrDefaultAsync(r => r.TicketID == id);

            if (ticket == null)
            {
                return View("Error", new String[] { "This order detail was not in the database!" });
            }

            return View(ticket);
        }

        // POST: Ticket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Ticket ticket = await _context.Ticket
                .Include(r => r.Order)
                .FirstOrDefaultAsync(r => r.TicketID == id);

            _context.Ticket.Remove(ticket);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Order", new { id = ticket.Order.OrderID });
        }

        private bool TicketExists(int id)
        {
            return _context.Ticket.Any(e => e.TicketID == id);
        }

        [Authorize(Roles="Manager")]
        public IActionResult ReportSearch()
        {

            //Populate view bag with list of categories
            ViewBag.AllMPAARatings = GetAllRatings();
            ViewBag.AllMovies = GetAllMovies();

            //Set default properties
            ReportSearchViewModel rsvm = new ReportSearchViewModel();

            return View(rsvm);
        }

        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> DisplayReportResultsAsync(ReportSearchViewModel rsvm)
        {
            //Initial query LINQ
            var query = from m in _context.Ticket select m;
            query = query.Include(m => m.Showing).ThenInclude(m => m.Movie).Include(m => m.Order).ThenInclude(m => m.Purchaser);

            //If statements corresponding to each input form control

            if (rsvm.SelectedStartingDate != null) //For date
            {
                DateTime datSelectedStartingDate = rsvm.SelectedStartingDate ?? new DateTime(1900, 1, 1);
                query = query.Where(m => m.Showing.ShowingDate >= datSelectedStartingDate);
            }

            if (rsvm.SelectedEndingDate != null) //For date
            {
                DateTime datSelectedEndingDate = rsvm.SelectedEndingDate ?? new DateTime(1900, 1, 1);
                query = query.Where(m => m.Showing.ShowingDate <= datSelectedEndingDate);
            }

            if (rsvm.SelectedMovie != 0) //For movie name
            {
                Movie movie = _context.Movies.Find(rsvm.SelectedMovie);
                query = query.Where(m => m.Showing.Movie == movie);
            }

            if (rsvm.SelectedMPAARating != 0) //For MPAARating
            {
                string MPAAStringToDisplay = Enum.GetName(typeof(AllMPAARatings), rsvm.SelectedMPAARating);
                MPAARatings MPAARatingsToDisplay = (MPAARatings)Enum.Parse(typeof(MPAARatings), MPAAStringToDisplay);
                query = query.Where(m => m.Showing.Movie.MPAARating == MPAARatingsToDisplay);
            }

            if (rsvm.SelectedTime != null) //For showing time ********
            {
                DateTime timSelectedTime = rsvm.SelectedTime ?? new DateTime(1900, 1, 1);

                if(rsvm.SelectedSearchType == AllSearchTypes.GreaterThan)
                {
                    ModelState.AddModelError("NotSelected", "Please choose either before or after for your selected time.");
                    //Populate view bag with list of categories
                    ViewBag.AllMPAARatings = GetAllRatings();
                    ViewBag.AllMovies = GetAllMovies();
                    return View("ReportSearch",rsvm);
                }


                switch (rsvm.SelectedSearchType)
                {
                    case AllSearchTypes.Before:
                        query = query.Where(m => m.Showing.StartTime.TimeOfDay <= timSelectedTime.TimeOfDay);
                        break;
                    case AllSearchTypes.After:
                        query = query.Where(m => m.Showing.StartTime.TimeOfDay >= timSelectedTime.TimeOfDay);
                        break;
                    default:
                        break;
                }
            }

            

            TryValidateModel(rsvm);
            if (ModelState.IsValid == false)
            {
                //re-populate ViewBag to have list of all categories & MPAA Ratings
                ViewBag.AllMPAARatings = GetAllRatings();
                ViewBag.AllMovies = GetAllMovies();


                //View is returned with error messages
                return View("ReportSearch", rsvm);
            }

            //Execute query

            List<Ticket> SelectedTickets = query.Include(m => m.Showing).ThenInclude(m => m.Movie).Include(m => m.Order).ThenInclude(m => m.Purchaser).ToList();//.Where(r => r.TicketStatus == "Active").ToList();
            ReportViewModel rvm = new ReportViewModel();

            if (rsvm.TotalRevenue != false) 
            {
                rvm.TotalRevenue = SelectedTickets.Where(t => t.TicketStatus == "Active").Sum(r => r.TotalCost);
            }
            if (rsvm.TotalSeatsSold != false) 
            {
                rvm.TotalSeatsSold = SelectedTickets.Where(t => t.TicketStatus == "Active").Count();
            }
            if (rsvm.ByCustomers != false)
            {
                IList<AppUser> users = await _userManager.GetUsersInRoleAsync("Customer");

                users = users.Where(u => u.OrdersPurchased != null).ToList();
                rvm.AppUsers = (List<AppUser>)users;
                foreach (AppUser user in rvm.AppUsers)
                {
                    user.Tickets = SelectedTickets.Where(t => t.Order.Purchaser.UserName == user.UserName).ToList();
                }
                //rvm.Tickets = SelectedTickets;
            }
            if (rsvm.PPTickets != false)
            {
                rvm.PopcornPointTickets = SelectedTickets.Where(r => r.Order.PaidWithPopcornPoints == true && r.TicketStatus == "Active").ToList();
            }

            return View("ReportSearchResults", rvm);

        }

        [Authorize(Roles = "Manager")]
        public IActionResult Transactions(string id)
        {
            List<Ticket> tickets = _context.Ticket
                                       .Include(rd => rd.Order).ThenInclude(rd => rd.Purchaser)
                                       .Include(rd => rd.Showing).ThenInclude(rd => rd.Movie)
                                       .Where(rd => rd.Order.Purchaser.Id == id)
                                       .ToList();

            return View(tickets);
        }
    }
}
