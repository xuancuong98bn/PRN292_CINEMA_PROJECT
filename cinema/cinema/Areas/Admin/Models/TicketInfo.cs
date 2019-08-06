using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Areas.Admin.Models
{
    public class TicketInfo
    {
        public int TicketID { get; set; }
        public ShowtimeInfo ShowtimeInfo { get; set; }
        public string SeatInfo { get; set; }
        public int Price { get; set; }
    }
}