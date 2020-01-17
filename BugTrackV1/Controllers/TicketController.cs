using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTrackV1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BugTrackV1.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            TicketContext ticketContext = new TicketContext();
            TicketModel ticket = ticketContext.Tickets.Single(x=>id==x.Id);

            //TicketModel ticketModel = new TicketModel()
            //{
            //    Id = 1,
            //    Title = "Solving Problem",
            //    Author = "Mannan"
            //};

            return View(ticket);
        }
    }
}