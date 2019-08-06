using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class Slot
    {
        public int ID { get; set; }
        public int RoomID { get; set; }
        public int TimeslotID { get; set; }
        public string Description { get; set; }
        public bool IsEnable { get; set; }

    }
}