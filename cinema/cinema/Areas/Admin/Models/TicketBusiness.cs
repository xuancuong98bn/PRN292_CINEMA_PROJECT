using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Areas.Admin.Models
{
    public class TicketBusiness //business model
    {
        public String CustomerName { get; set; }
        public String Film { get; set; }
        public String Room { get; set; }
        public DateTime BeginTime  { get; set; }
        public DateTime EndTime { get; set; }
        public String SeateInfo { get; set; }
        public DateTime Booktime { get; set; }
        public int Price { get; set; }
    }
}