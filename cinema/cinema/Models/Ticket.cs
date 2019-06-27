using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace cinema.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public int ShowtimeID { get; set; }
        public int SeatID { get; set; }     //prom seatID -> price
        public int status { get; set; } //-1 booked, 0: booking,   1: available

        //room
        //price
    }
}