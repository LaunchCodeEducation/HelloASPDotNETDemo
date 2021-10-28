using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        static private List<string> Events = new List<string>();
        [HttpGet]
        public IActionResult Index()
        {
            Events.Add("Code the Kasbah");
            Events.Add("Bringing Coding Back");
            Events.Add("Bohemian Codesody");
            ViewBag.events = Events;
            return View();
        }
    }
}
