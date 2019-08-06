using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Areas.Admin.Models
{
    public class ShowtimeInfo
    {
        public int ShowtimeID { get; set; } //showtime
        public string FilmName { get; set; }    //film
        public string SlotDes { get; set; } //slot
        //public string seatInfo { get; set; }    //rowth, columnth
        //public DateTime BookTime { get; set; }  //user_ticket
        //public int Price { get; set; }  //ticket
    }
}