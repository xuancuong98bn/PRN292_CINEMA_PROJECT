using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public int ShowtimeID { get; set; }
        public int SeatID { get; set; }
        public int Price { get; set; }
        public int Status { get; set; }     //0: available 
                                            //1: booked
    }
}