using Microsoft.EntityFrameworkCore;
using Tickets.Models;

namespace Tickets.Data
{
    public class TicketManagerContext : DbContext
    {
        public TicketManagerContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TicketModel> Tickets { get; set; }
    }
}
