using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class Room_Seattype
    {
        public int ID { get; set; }
        public int RoomID { get; set; }
        public int Rowth { get; set; }
        public int SeattypeID { get; set; }
        public bool IsEnable { get; set; }
    }
}