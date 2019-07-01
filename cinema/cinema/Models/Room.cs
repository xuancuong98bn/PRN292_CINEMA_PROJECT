using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int RowQuantity { get; set; }
        public int ColumnQuantity { get; set; }
        public bool IsEnable { get; set; }
    }
}