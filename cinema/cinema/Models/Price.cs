using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class Price
    {
        public int ID { get; set; }
        public int FilmID { get; set; }
        public int TimeslotID { get; set; }
        public int SeatTypeID { get; set; }

        public int price { get; set; }
    }
}