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
        public int SlotID { get; set; }
        public int OriginPrice { get; set; }
        public bool IsEnable { get; set; }
    }
}