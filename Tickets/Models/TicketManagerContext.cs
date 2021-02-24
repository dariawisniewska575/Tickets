using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tickets.Models
{
    public class TicketManagerContext : DbContext
    {
        public TicketManagerContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TicketModel> Tickets { get; set; }
    }
}
