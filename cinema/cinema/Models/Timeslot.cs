using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class Timeslot
    {
        public int ID { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class TimeslotDBContext : DbContext
    {
        public DbSet<Timeslot> Timeslots { get; set; }
    }
}