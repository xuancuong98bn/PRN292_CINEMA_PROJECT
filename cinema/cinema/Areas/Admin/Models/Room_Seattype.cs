using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Areas.Admin.Models
{
    public class Room_Seattype  //business model
    {
        public int RoomID { get; set; }
        public Dictionary<int, int> RowthWithType { get; set; }
    }
}