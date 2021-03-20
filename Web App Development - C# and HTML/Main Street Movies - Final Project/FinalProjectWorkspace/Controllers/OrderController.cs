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
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Order
        [Authorize]
        public IActionResult Index()
        {
            List<Order> Orders = new List<Order>();
            if (User.IsInRole("Manager") || User.IsInRole("Employee"))
            {
                Orders = _context.Order
                    .Include(o => o.Seller)
                    .Include(o => o.Purchaser)
                    .Include(o => o.Recipient)
                    .Include(o => o.Tickets).ThenInclude(o => o.Showing).ToList();
            }
            else //user is a customer
            {
                Orders = _context.Order
                    .Include(o => o.Seller)
                    .Include(o => o.Purchaser)
                    .Include(o => o.Recipient)
                    .Where(o => o.Recipient.UserName == User.Identity.Name
                                                || o.Purchaser.UserName == User.Identity.Name).Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ToList();
            }

            return View(Orders.OrderByDescending(o => o.OrderDate));
        }

        // GET: Order/Details/5
        public IActionResult Details(int? id)
        {
            //if no registration was specifieds
            if (id == null)
            {
                return View("Error", new String[] { "Please specify an order to view!" });
            }

            //Find order in database that corresponds to user
            Order order = _context.Order
                .Include(ord => ord.Tickets.OrderBy(t => t.Showing.StartTime)).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .Include(ord => ord.Seller)
                .FirstOrDefault(o => o.OrderID == id);

            //if registration wasn't found
            if (order == null)
            {
                return View("Error", new String[] { "This order was not found!" });
            }
            if (order.Seller == null)
            {
                //make sure a customer isn't trying to look at someone else's order
                if (!User.IsInRole("Manager") && order.Purchaser.UserName != User.Identity.Name && order.Recipient.UserName != User.Identity.Name)
                {
                    return View("Error", new string[] { "You are not authorized to edit this order!" });
                }
            }
            //make sure a customer isn't trying to look at someone else's order. (They aren't the seller, purchaser, or recipient)
            else if (!User.IsInRole("Manager") && order.Seller.UserName != User.Identity.Name && order.Purchaser.UserName != User.Identity.Name && order.Recipient.UserName != User.Identity.Name)
            {
                return View("Error", new string[] { "You are not authorized to edit this order!" });
            }

            return View(order);
        }

        // GET: Order/Details/5
        public IActionResult ActiveOrder(int? id, String customer)
        {
            //create a dummy order
            Order order = _context.Order.FirstOrDefault();

            if (customer != null)
            {
                order = _context.Order
                .Include(ord => ord.Tickets.OrderBy(t => t.Showing.StartTime)).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .Include(ord => ord.Seller)
                .Where(ord => ord.OrderStatus == "Active")
                .FirstOrDefault(o => o.Purchaser.UserName == customer);
            }
            else if (User.IsInRole("Employee") || User.IsInRole("Manager"))
            {
                //Find order in database that corresponds to user
                order = _context.Order
                    .Include(ord => ord.Tickets.OrderBy(t => t.Showing.StartTime)).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                    .Include(ord => ord.Recipient)
                    .Include(ord => ord.Purchaser)
                    .Include(ord => ord.Seller)
                    .Where(ord => ord.OrderStatus == "Active")
                    .FirstOrDefault(o => o.Seller.UserName == User.Identity.Name);
            }
            else {
            //Find order in database that corresponds to user
            order = _context.Order
                .Include(ord => ord.Tickets.OrderBy(t => t.Showing.StartTime)).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .Include(ord => ord.Seller)
                .Where(ord => ord.OrderStatus == "Active")
                .FirstOrDefault(o => o.Purchaser.UserName == User.Identity.Name);
            }

            //if registration wasn't found
            if (order == null)
            {
                return View("Error", new String[] { "There is no active order! Please buy a ticket for an order to be created." });
            }

            if (order.Seller == null)
            {
                //make sure a customer isn't trying to look at someone else's order
                if (!User.IsInRole("Manager") && order.Purchaser.UserName != User.Identity.Name && order.Recipient.UserName != User.Identity.Name)
                {
                    return View("Error", new string[] { "You are not authorized to edit this order!" });
                }
            }
            //make sure a customer isn't trying to look at someone else's order. (They aren't the seller, purchaser, or recipient)
            else if (!User.IsInRole("Manager") && order.Seller.UserName != User.Identity.Name && order.Purchaser.UserName != User.Identity.Name && order.Recipient.UserName != User.Identity.Name)
            {
                return View("Error", new string[] { "You are not authorized to edit this order!" });
            }

            return View("Details",order);
        }

        public IActionResult InvalidEmail()
        {
            return View();
        }

        public IActionResult ValidEmail(String customer)
        {
            ViewBag.Customer = customer;
            return View();
        }

        public IActionResult SellTicket()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SellTicket(String customer)
        {
            if (customer == null)
            {
                ModelState.AddModelError("No email was entered.", "Please enter a customer's email.");
                return View();
            }

            AppUser customerDB = _context.Users.Where(u => u.Email == customer).FirstOrDefault();

            if (customerDB == null)
            {
                return RedirectToAction(nameof(InvalidEmail));
                
            } else
            {
                return RedirectToAction(nameof(ValidEmail), new { customer });
            }

        }

        // GET: Order/Create
        public IActionResult Create(int? showingID)
        {
            //Find order in database that corresponds to user
            Order orderInDB = _context.Order
                .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .Where(ord => ord.OrderStatus == "Active")
                .FirstOrDefault(o => o.Purchaser.UserName == User.Identity.Name);

            if (orderInDB != null)
            {
                return RedirectToAction("Details", "Order", new { id = orderInDB.OrderID });
                //return View("Error", new string[] { "You already have an active cart! Click the cart in the upper right corner to add tickets or view our showings now." });
            }

            return View(showingID);
        }

        // POST: Order/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,TransactionNumber,OrderDate,OrderStatus")] Order order, int? showingID, String customer)
        {
            //Find order in database that corresponds to user
            //Create dummy order that will be changed later
            Order orderInDB = _context.Order.FirstOrDefault();
            if ((User.IsInRole("Employee") || User.IsInRole("Manager")) && customer == null)
            {
                //Find order in database that corresponds to user
                order = _context.Order
                    .Include(ord => ord.Tickets.OrderBy(t => t.Showing.StartTime)).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                    .Include(ord => ord.Recipient)
                    .Include(ord => ord.Purchaser)
                    .Include(ord => ord.Seller)
                    .Where(ord => ord.OrderStatus == "Active")
                    .FirstOrDefault(o => o.Seller.UserName == User.Identity.Name);

                if ((User.IsInRole("Employee") || User.IsInRole("Manager")) & order == null)
                {
                    return View("Error", new String[] { "You cannot place an order on this account. Please sign into a customer account." });

                }

                customer = order.Purchaser.UserName;
            }

          

            if (customer != null)
            {
                //Checks if there's an active order
                orderInDB = _context.Order
                    .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                    .Include(ord => ord.Recipient)
                    .Include(ord => ord.Purchaser)
                    .Where(ord => ord.OrderStatus == "Active")
                    .FirstOrDefault(o => o.Purchaser.UserName == customer);
            }
            //a customer is buying for themselves
            else
            {
                //Checks if there's an active order
                orderInDB = _context.Order
                    .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                    .Include(ord => ord.Recipient)
                    .Include(ord => ord.Purchaser)
                    .Where(ord => ord.OrderStatus == "Active")
                    .FirstOrDefault(o => o.Purchaser.UserName == User.Identity.Name);
            }

            if (orderInDB != null)
            {
                order = orderInDB;

                if (customer != null)
                {
                    AppUser customerDB = _context.Users.Where(u => u.Email == customer).FirstOrDefault();
                    order.Purchaser = customerDB;
                    order.Seller = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

                    //if code gets this far, add the registration to the database
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }

                //make sure all properties are valid
                if (ModelState.IsValid == false)
                {
                    return View(order);
                }
            }
            else
            {
                //if an employee specified the customer they're selling to
                if (customer != null)
                {
                    AppUser customerDB = _context.Users.Where(u => u.Email == customer).FirstOrDefault();
                    order.Purchaser = customerDB;
                    order.Seller = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name); 
                }
                //a customer is buying for themselves
                else
                {
                    //Associate order with the logged in customer TODO: add logic here for gifting?
                    order.Purchaser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                }
                //TODO: Set order number automatically
                order.TransactionNumber = Utilities.GenerateNextTransactionNumber.GetNextTransactionNumber(_context);

                //Set order date to right now
                order.OrderDate = DateTime.Now;

                order.OrderStatus = "Active";

                //make sure all properties are valid
                if (ModelState.IsValid == false)
                {
                    return View(order);
                }

                //if code gets this far, add the registration to the database
                _context.Add(order);
                await _context.SaveChangesAsync();

            }

            if (order.Seller != null)
            {
                if(showingID == null)
                {
                    return RedirectToAction("ActiveOrder", "Order", new { customer });

                } else
                {
                    return RedirectToAction("Create", "Ticket", new { orderID = order.OrderID, showingID });
                }
            }
            else {
            //send the user on to the action that will allow them to 
            //create a registration detail.  Be sure to pass along the RegistrationID
            //that you created when you added the registration to the database above
                if (showingID == null)
                {
                    return RedirectToAction("Create", "Ticket", new { orderID = order.OrderID});

                }
                else
                {
                    return RedirectToAction("Create", "Ticket", new { orderID = order.OrderID, showingID });
                }
            }

        }

        // GET: Order/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("Error2", new String[] { "There was a problem finding this order. Try again!" });
            }

            //Find order in database that corresponds to user
            Order order = _context.Order
                .Include(ord => ord.Tickets.OrderBy(t => t.Showing.StartTime)).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .FirstOrDefault(o => o.OrderID == id);

            if (order == null)
            {
                return View("Error2", new String[] { "There was a problem finding this order. Try again!" });
            }
            return View(order);
        }

        // POST: Order/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,TransactionNumber,OrderDate,OrderStatus")] Order order)
        {
            if (id != order.OrderID)
            {
                return View("Error", new String[] { "There was a problem editing this order. Try again!" });
            }

            //if there is something wrong with this order, try again
            if (ModelState.IsValid == false)
            {
                return View(order);
            }

            //if code gets this far, update the record
            try
            {
                //find the record in the database
                Order dbOrder = _context.Order.Find(order.OrderID);

                //update the notes
                //TODO: What would they even update?
                //dbOrder.OrderNotes = order.OrderNotes;

                _context.Update(dbOrder);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this order!", ex.Message });
            }

            //send the user to the Orders Index page.
            return RedirectToAction(nameof(Index));
        }

        // GET: Order/Edit/5
        [HttpGet, ActionName("CompleteOrder")]
        public IActionResult CompleteOrder(Order orderIn)
        {
            if (orderIn.OrderID == 0)
            {
                return View("Error2", new String[] { "Could not find this order. Please Try Again." });
            }

            //Find order in database that corresponds to user
            Order order = _context.Order
                .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .Include(ord => ord.Seller)
                .FirstOrDefault(o => o.OrderID == orderIn.OrderID);

            order.PaidWithPopcornPoints = orderIn.PaidWithPopcornPoints;
            if (order.PaidWithPopcornPoints == true)
            {
                ViewBag.PaidWithPopcornPoints = 1;
            } else
            {
                ViewBag.PaidWithPopcornPoints = 0;
            }
            if (order.PaidWithPopcornPoints == true)
            {
                foreach (Ticket t in order.Tickets)
                {
                    t.TotalCost = 0;
                    t.TransactionPopcornPoints = -100.00m;
                }
                order.PopcornPoints = order.Tickets.Count() * -100;
                order.Purchaser.PCPBalance -= Math.Abs(order.PopcornPoints);
                ViewBag.PopcornPoints = order.PopcornPoints;
                ViewBag.PCPBalance = order.Purchaser.PCPBalance;
            }
            else
            {
                order.PopcornPoints = (int)order.Tickets.Sum(t => t.TransactionPopcornPoints);
                order.Purchaser.PCPBalance = order.Purchaser.PCPBalance + order.PopcornPoints;
                ViewBag.PopcornPoints = order.PopcornPoints;
                ViewBag.PCPBalance = order.Purchaser.PCPBalance;
            }

            if (orderIn.Recipient.UserName != null)
            {
                //Prevent someone from gifting an order to themselves
                if (orderIn.Recipient.UserName == order.Purchaser.UserName)
                {
                    return View("Error", new String[]
                    { "You can't gift an order to yourself!" });

                }

                AppUser user = _context.Users.Where(u => u.UserName == orderIn.Recipient.UserName).FirstOrDefault();
                if (user != null)
                {
                    List<Movie> movies = order.Tickets.Select(t => t.Showing.Movie).ToList();

                    foreach (Movie m in movies)
                    {
                        if (user.Birthday.AddYears(18) >= DateTime.Now)
                        {
                            if (m.MPAARating == MPAARatings.R || m.MPAARating == MPAARatings.NC17)
                            {
                                return View("Error", new String[]
                                { "The recipient is under 18 and they cannot be gifted a showing to " + m.Title + "."});
                            }
                        }
                    }
                    order.Recipient = user;
                    ViewBag.Recipient = user;
                }
                else
                {
                    return View("Error", new String[] { "This user doesn't have a Main Street Movies account! Please have them create one before gifting them tickets." });
                }
            }

            //TODO: If we uncomment this, then popcorn points get deducted successfully. We would have to remove "Return To Index" on the confirmation page.s
            //_context.Update(order);
            //await _context.SaveChangesAsync();

            if (order == null)
            {
                return View("Error2", new String[] { "Could not find this order. Please Try Again." });
            }

            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CompleteOrder(Order orderIn, int pcpBalance, int popcornPoints, String recipient, int paidPP)
        {
            //Find order in database that corresponds to user
            Order order = _context.Order
                .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .FirstOrDefault(o => o.OrderID == orderIn.OrderID);

            if(recipient != null)
            {
                AppUser recipientUser = _context.Users.Where(u => u.UserName == recipient).First();
                order.Recipient = recipientUser;
            }

            order.OrderStatus = "Paid";
            if (paidPP == 0)
            {
                order.PaidWithPopcornPoints = false;
            } else if (paidPP == 1)
            {
                order.PaidWithPopcornPoints = true;
                foreach (Ticket t in order.Tickets)
                {
                    t.TotalCost = 0;
                    t.TicketPrice = 0;
                    t.TransactionPopcornPoints = 0;

                    _context.Update(t);
                    await _context.SaveChangesAsync();
                }
            }
            order.PopcornPoints = popcornPoints;
            order.Purchaser.PCPBalance = pcpBalance;

            _context.Update(order);
            await _context.SaveChangesAsync();

            //send the user to the Orders Index page.
            return RedirectToAction(nameof(Confirmed),order);
        }



        public IActionResult ConfirmedEmail(Order order)
        {
            return View("Confirmed", order);

            //return View(order);
        }

        // GET: Order/Edit/5
        public IActionResult Confirmed(Order order)
        {
            return RedirectToAction("OrderConfirmed", "Email", new { order.OrderID });

            //return View(order);
        }

        public async Task<IActionResult> Cancelled(int id)
        {
            if (id == 0)
            {
                return View("Error2", new String[] { "Could not find this order. Please Try Again." });
            }

            //Find order in database that corresponds to user
            Order order = _context.Order
                .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .FirstOrDefault(o => o.OrderID == id);

            //if code gets this far, update the record
            try
            {
                //find the record in the database
                //Order dbOrder = _context.Order.Find(order.OrderID);

                //update the order status to cancelled
                order.OrderStatus = "Cancelled";

                if (order.PaidWithPopcornPoints == true)
                {
                    order.Purchaser.PCPBalance += Math.Abs(order.PopcornPoints);
                    order.PopcornPoints = 0;
                   
                } else
                {
                    order.Purchaser.PCPBalance -= order.PopcornPoints;
                    order.PopcornPoints = 0;
                }

                foreach(Ticket t in order.Tickets)
                {
                    t.TotalCost = 0;
                    t.TicketPrice = 0;
                    t.TransactionPopcornPoints = 0;
                    t.DiscountName = DiscountNames.None;
                    t.TicketStatus = "Cancelled";
                    t.DiscountAmount = 0;
                }

                _context.Update(order);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this order!", ex.Message });
            }

            //send the user to the Orders Index page.
            //return View(order);
            
            return RedirectToAction("OrderCancelled", "Email", new { order.OrderID });

        }


        public IActionResult CancelledEmail(Order order)
        {
            return View("Cancelled", order);

            //return View(order);
        }




        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.OrderID == id);
        }
    }
}
