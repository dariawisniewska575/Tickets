﻿using System.Collections.Generic;
using Tickets.Models;

namespace Tickets.Repositories
{
    public interface ITicketRepository
    {
        public TicketModel Get(int taskId);
        public void Add(TicketModel ticket);
        public void Update(int taskId, TicketModel ticket);
        public void Delete(int taskId);
        public IEnumerable<TicketModel> GetAll();
    }
}
