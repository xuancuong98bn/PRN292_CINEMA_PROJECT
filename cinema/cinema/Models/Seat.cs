using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class Seat
    {
        public int ID { get; set; }
        public int Row { get; set; }
        public int Columnn { get; set; }
        public int SeatTypeID { get; set; }
    }
}