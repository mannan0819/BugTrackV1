using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackV1.Models
{
    public class TicketContext : DbContext
    {
        public DbSet<TicketModel> Tickets { get; set; }
    }
}
