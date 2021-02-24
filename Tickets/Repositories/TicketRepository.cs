using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tickets.Models;

namespace Tickets.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly TicketManagerContext context;
        TicketModel ticketModel;
        public TicketRepository(TicketManagerContext context)
        {
            this.context = context;
        }
        public void Add(TicketModel ticket)
        {
            ticket.Date = DateTime.Now;
            ticket.Status = "New";
            context.Tickets.Add(ticket);
            context.SaveChanges();
        }
        public TicketModel Get(int taskId)
            => this.context.Tickets.SingleOrDefault(x => x.ID == taskId);
        public void Update(int taskId, TicketModel ticket)
        {
            var result = context.Tickets.SingleOrDefault(x => x.ID == taskId);
            if (result != null)
            {
                result.Title = ticket.Title;
                result.Description = ticket.Description;
                result.Date = ticket.Date;
                result.Status = ticket.Status;
                context.SaveChanges();
            }
        }
        public void Delete(int taskId)
        {
            var result = context.Tickets.SingleOrDefault(x => x.ID == taskId);
            if (result != null)
            {
                context.Tickets.Remove(result);
                context.SaveChanges();
            }
        }

        public IEnumerable<TicketModel> GetAll()
            => context.Tickets.Where(x => x.ID < 100);

    }
}
