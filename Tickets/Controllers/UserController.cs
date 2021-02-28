using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tickets.Models;
using Tickets.Repositories;

namespace Tickets.Controllers
{
    public class UserController : Controller
    {
        private readonly ITicketRepository ticketRepository;
        public UserController(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }
        [Authorize(Roles = "User")]
        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "User")]
        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "User")]
        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TicketModel ticketModel)
        {
            ticketRepository.Add(ticketModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
