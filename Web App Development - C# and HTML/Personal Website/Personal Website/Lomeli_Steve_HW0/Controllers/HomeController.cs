using Microsoft.AspNetCore.Mvc;
using Lomeli_Steve_HW0.Models;
using System.Linq;
using System.Collections.Generic;

namespace Lomeli_Steve_HW0.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }

        }

        public IActionResult ListResponses()
        {
            IEnumerable<GuestResponse> attendeeList =
                                            Repository.Responses.Where(r => r.WillAttend == true);
            return View(attendeeList);
        }

    }
}