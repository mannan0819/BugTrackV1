using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackV1.Models
{
    [Table("tblTicket")]
    public class TicketModel
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Author { set; get; }

    }
}
