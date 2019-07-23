using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class Seattype
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int PlusPrice { get; set; }
        public bool IsEnable { get; set; }
    }
}