using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class Timeslot
    {
        public int ID { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }

        public bool IsEnable { get; set; }
    }
}