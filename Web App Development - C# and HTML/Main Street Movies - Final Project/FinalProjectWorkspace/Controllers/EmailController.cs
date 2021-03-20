using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text;
using System.Net.Mime;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProjectWorkspace.Controllers
{
    public class EmailController : Controller
    {

        private readonly AppDbContext _context;
        //private readonly IRazorViewToStringRenderer _renderer;

        public EmailController(AppDbContext context)
        {
            _context = context;
            //_renderer = renderer;
        }



        public async Task<ActionResult> Contact(string id)
        {
            AppUser user;

            user = _context.Users.FirstOrDefault(u => u.Id == id);

            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("jeremiahw124@outlook.com")); //replace with valid value
                message.From = new MailAddress("dak.mainst@gmail.com", "Dak from Main St.");
                message.Subject = "Your email subject";
                message.Body = string.Format(body, user.FirstName, user.Email, user.Birthday);
                message.IsBodyHtml = true;



                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {

                    smtp.Credentials = new NetworkCredential("dak.mainst@gmail.com", "basic123!");
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Index", "Home");
        }

        



        public async Task<ActionResult> OrderCancelled(int orderID)
        {
            AppUser user;

            Order order = _context.Order
                .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .FirstOrDefault(o => o.OrderID == orderID);

            user = _context.Users.FirstOrDefault(u => u.Id == order.Purchaser.Id);

            string msEmail = Convert.ToString(user.Email);

            if (ModelState.IsValid)
            {
                if (User.IsInRole("Manager"))
                {
                    var body = "<h1>Hello {0}!</h1><p>Thank you for choosing Main St.!</p><p>Your order was cancelled by a manager. Here are the details of the cancelled order: </p></br>" +
                    "<p>Transaction Number: {1}</p></br><p>Order Date: {2}</p><p>Purchaser: {3}</p>" +
                    "<p>You will be refunded to the original payment method. Please contatc us so we can reschedule you for another showing. If you need any more assistance, please contact us.</p><p>Have a great rest of your day!</p></br><p>~ Dak from Main St.</p>";
                    var message = new MailMessage();
                    message.To.Add(new MailAddress(msEmail)); //replace with valid value
                    message.From = new MailAddress("dak.mainst@gmail.com", "Dak from Main St.");
                    message.Subject = "Team 17: Sorry! Your Order was Canceled";
                    message.Body = string.Format(body, user.FirstName, order.TransactionNumber, order.OrderDate, order.Purchaser);
                    message.IsBodyHtml = true;



                    using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                    {

                        smtp.Credentials = new NetworkCredential("dak.mainst@gmail.com", "basic123!");
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        await smtp.SendMailAsync(message);
                        return RedirectToAction("CancelledEmail", "Order", order);
                    }
                }

                else
                {
                    var body = "<h1>Hello {0}!</h1><p>Thank you for choosing Main St.!</p><p>Your order was canceled. Here are the details of the cancelled order: </p></br>" +
                    "<p>Transaction Number: {1}</p></br><p>Order Date: {2}</p><p>Purchaser: {3}</p>" +
                    "<p>You will be refunded to the original payment method. If you need any more assistance, please contact us.</p><p>Have a great rest of your day!</p></br><p>~ Dak from Main St.</p>";
                    var message = new MailMessage();
                    message.To.Add(new MailAddress(msEmail)); //replace with valid value
                    message.From = new MailAddress("dak.mainst@gmail.com", "Dak from Main St.");
                    message.Subject = "Team 17: Order Cancellation";
                    message.Body = string.Format(body, user.FirstName, order.TransactionNumber, order.OrderDate, order.Purchaser);
                    message.IsBodyHtml = true;



                    using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                    {

                        smtp.Credentials = new NetworkCredential("dak.mainst@gmail.com", "basic123!");
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        await smtp.SendMailAsync(message);
                        return RedirectToAction("CancelledEmail", "Order", order);
                    }
                }
            }

            return View("Error", new String[] { "Unable to send the email!" });
        }









        public async Task<ActionResult> OrderConfirmed(int orderID)
        {
            AppUser user;


            Order order = _context.Order
                .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .FirstOrDefault(o => o.OrderID == orderID);


            //
            //user = _context.Users.FirstOrDefault(u => u.Id == order.Purchaser.Id);
            user = _context.Users.FirstOrDefault(u => u.Id == order.Purchaser.Id);

            string msEmail = Convert.ToString(user.Email);

            var orderSub = order.OrderSubtotal.ToString("0.00");
            var orderTax = order.Taxes.ToString("0.00");
            var orderTotal = order.OrderTotal.ToString("0.00");


            if (ModelState.IsValid)
            {
                var body = "<h1>Hello {0}!</h1><p>Thank you for choosing Main St.!</p><p>Rock on!! Your order was confirmed! Here are the deets: </p></br>" +
                    "<p>Transaction Number: {1}</p></br><p>Order Date: {2}</p><p>Order Subtotal: ${3}</p><p>Taxes: ${4}</p><p>Order Total: ${5}</p> " +
                    "<p>Popcorn Points: {6}</p><p>Paid With PopcornPoints: {7}</p><p>Purchaser: {8}</p>" +
                    "<p>If you need any more assistance, please contact us.</p><p>Have a great rest of your day!</p></br><p>~ Dak from Main St.</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress(msEmail)); //replace with valid value
                message.From = new MailAddress("dak.mainst@gmail.com", "Dak from Main St.");
                message.Subject = "Team 17: Order Confirmation";
                message.Body = string.Format(body, user.FirstName, order.TransactionNumber, order.OrderDate, orderSub, orderTax, orderTotal, order.PopcornPoints, order.PaidWithPopcornPoints,
                    order.Purchaser);
                message.IsBodyHtml = true;



                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {

                    smtp.Credentials = new NetworkCredential("dak.mainst@gmail.com", "basic123!");
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("ConfirmedEmail", "Order", order);
                }
            }
            return View("Error", new String[] { "Unable to send the email!" });
        }





        public async Task<ActionResult> AccountUpdate(string id)
        {
            AppUser user;

            user = _context.Users.FirstOrDefault(u => u.Id == id);

            string msEmail = Convert.ToString(user.Email);

            if (ModelState.IsValid)
            {
                var body = "<h1>Hello {0}!</h1><p>Thank you for choosing Main St!</p><p>Your account {1} was recently updated. If you did not initiate this change, please contact us to reset your password." +
                    "</p><p>Have a great rest of your day!</p></br><p>~ Dak from Main St.</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress(msEmail)); //replace with valid value
                message.From = new MailAddress("dak.mainst@gmail.com", "Dak from Main St.");
                message.Subject = "Team 17: Account Update";
                message.Body = string.Format(body, user.FirstName, user.Email);
                message.IsBodyHtml = true;



                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {

                    smtp.Credentials = new NetworkCredential("dak.mainst@gmail.com", "basic123!");
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Index", "Account", new { id = user.Id });
                }
            }
            return View("Error", new String[] { "Unable to send the email!" });
        }




        public async Task<ActionResult> AccountCreation(string id, string emailPassword)
        {
            AppUser user;

            user = _context.Users.FirstOrDefault(u => u.Id == id);

            string msEmail = Convert.ToString(user.Email);

            if (ModelState.IsValid)
            {
                var body = "<h1>Hello {0}!</h1><p>Thank you for choosing Main St!</p><p>Your account was successfully created! " +
                    "Your Account information is below:</p></br><p>Email: {1}</p><p>Password: {2}</p></br><p>To sign in, please use this email address and the password you set. " +
                    "If you did not create this account or forgot your password, please contact us." +
                    "</p><p>Have a great rest of your day!</p></br><p>~ Dak from Main St.</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress(msEmail)); //replace with valid value
                message.From = new MailAddress("dak.mainst@gmail.com", "Dak from Main St.");
                message.Subject = "Team 17: Account Creation";
                message.Body = string.Format(body, user.FirstName, user.Email, emailPassword);
                message.IsBodyHtml = true;



                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {

                    smtp.Credentials = new NetworkCredential("dak.mainst@gmail.com", "basic123!");
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Index", "Home", new { id = user.Id });
                }
            }
            return View("Error", new String[] { "Unable to send the email!" });
        }






        

        public async Task<ActionResult> MovieModification(int ticketPurchaserID)
        {
            AppUser user;

            Order order = _context.Order
                .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                .Include(ord => ord.Recipient)
                .Include(ord => ord.Purchaser)
                .FirstOrDefault(o => o.OrderID == ticketPurchaserID);

            user = _context.Users.FirstOrDefault(u => u.Id == order.Purchaser.Id);

            string msEmail = Convert.ToString(user.Email);

            if (ModelState.IsValid)
            {
                var body = "<h1>Hello {0}!</h1><p>Thank you for choosing Main St.!</p><p>Some tickets on your order were modified. Here are the details of the rescheduled order: </p></br>" +
                    "<p>Transaction Number: {1}</p></br><p>Order Date: {2}</p><p>Purchaser: {3}</p>" +
                    "<p>Please log in to your account to view these changes. If you need any more assistance, please contact us.</p><p>Have a great rest of your day!</p></br><p>~ Dak from Main St.</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress(msEmail)); //replace with valid value
                message.From = new MailAddress("dak.mainst@gmail.com", "Dak from Main St.");
                message.Subject = "Team 17: Order Modification";
                message.Body = string.Format(body, user.FirstName, order.TransactionNumber, order.OrderDate, order.Purchaser);
                message.IsBodyHtml = true;



                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {

                    smtp.Credentials = new NetworkCredential("dak.mainst@gmail.com", "basic123!");
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Index", "Showing");
                }
            }
            return View("Error", new String[] { "Unable to send the email!" });


        }

        public async Task<ActionResult> MovieModificationList(int[] ticketPurchaserIDs)
        {
            AppUser user;
            String theatre = "0";
            DateTime showingDate = new DateTime(1900,1,1);

            foreach(int orderID in ticketPurchaserIDs)
            {
                try
                {
                    
                    Order order = _context.Order
                    .Include(ord => ord.Tickets).ThenInclude(ord => ord.Showing).ThenInclude(ord => ord.Movie)
                    .Include(ord => ord.Recipient)
                    .Include(ord => ord.Purchaser)
                    .FirstOrDefault(o => o.OrderID == orderID);

                    user = _context.Users.FirstOrDefault(u => u.Id == order.Purchaser.Id);
                    string msEmail = Convert.ToString(user.Email);

                    if (ModelState.IsValid)
                    {
                        var body = "<h1>Hello {0}!</h1><p>Thank you for choosing Main St.!</p><p>Your order was modified by Main St. Staff. Here are the details of the rescheduled order: </p></br>" +
                            "<p>Transaction Number: {1}</p></br><p>Order Date: {2}</p><p>Purchaser: {3}</p>" +
                            "<p>Please log in to your account to view these changes. If you need any more assistance, please contact us.</p><p>Have a great rest of your day!</p></br><p>~ Dak from Main St.</p>";
                        var message = new MailMessage();
                        message.To.Add(new MailAddress(msEmail)); //replace with valid value
                        message.From = new MailAddress("dak.mainst@gmail.com", "Dak from Main St.");
                        message.Subject = "Team 17: Order Modification";
                        message.Body = string.Format(body, user.FirstName, order.TransactionNumber, order.OrderDate, order.Purchaser);
                        message.IsBodyHtml = true;



                        using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                        {

                            smtp.Credentials = new NetworkCredential("dak.mainst@gmail.com", "basic123!");
                            smtp.Host = "smtp.gmail.com";
                            smtp.Port = 587;
                            smtp.EnableSsl = true;
                            await smtp.SendMailAsync(message);
                        }
                    }

                    if (order.Tickets.Select(s => s.Showing.Theatre).First() == Theatre.Theatre1)
                    {
                        theatre = "0";
                    }
                    else
                    {
                        theatre = "1";
                    }
                    showingDate = order.Tickets.Select(t => t.Showing.ShowingDate).First();
                }
                catch
                {
                    return View("Error", new String[] { "Unable to send the email!" });
                }
            }
            return RedirectToAction("Index", "Showing", new { theatre, showingDate});

        }











    }
}
