using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class Showtime
    {
        public int ID { get; set; }
        public int FilmID { get; set; }
        public int RoomID { get; set; }
        public int TimeslotID { get; set; }
    }
}