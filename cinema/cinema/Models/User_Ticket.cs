using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cinema.Models
{
    public class User_Ticket
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int TicketID { get; set; }

        public DateTime BookedTime { get; set; }
    }
}