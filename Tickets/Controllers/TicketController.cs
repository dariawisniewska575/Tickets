using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tickets.Models;
using Tickets.Repositories;

namespace Tickets.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketRepository ticketRepository;
        public TicketController(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }
        // GET: TicketController
        public ActionResult Index()
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
