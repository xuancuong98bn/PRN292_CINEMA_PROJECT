using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class PriceTable
    {
        public int ID { get; set; }
        public int ShowtimeID { get; set; }
        public int SeattypeID { get; set; }
        public double Price { get; set; }
        public bool IsEnable { get; set; }
    }
}