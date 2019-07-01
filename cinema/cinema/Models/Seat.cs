using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class Seat
    {
        public int ID { get; set; }
        public int RoomID { get; set; }
        public int Rowth { get; set; }
        public int Columnth { get; set; }
        public bool IsEnable { get; set; }
    }
}