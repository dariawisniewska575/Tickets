using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tickets.Models;
using Tickets.Repositories;

namespace Tickets.Controllers
{
    public class AdminController : Controller
    {
        
     private readonly ITicketRepository ticketRepository;
     public AdminController(ITicketRepository ticketRepository)
     {
        this.ticketRepository = ticketRepository;
     }
    [Authorize(Roles = "Admin")]
    public IActionResult Index()
        {
            return View(ticketRepository.GetAll());
        }
        // GET: TicketController/Details/5
        public ActionResult Details(int id)
        {
            return View(ticketRepository.Get(id));
        }

        // GET: TicketController/Create
        public ActionResult Create()
        {
            return View(new TicketModel());
        }

        // POST: TicketController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TicketModel ticketModel)
        {
            ticketRepository.Add(ticketModel);
            return RedirectToAction(nameof(Index));

        }

        // GET: TicketController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(ticketRepository.Get(id));
        }

        // POST: TicketController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TicketModel ticketModel)
        {
            ticketRepository.Update(id, ticketModel);
            return RedirectToAction(nameof(Index));

        }

        // GET: TicketController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(ticketRepository.Get(id));
        }

        // POST: TicketController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TicketModel ticketModel)
        {
            ticketRepository.Delete(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
