using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class Room
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Row { get; set; }
        public int Columnn { get; set; }
    }

    public class RoomDBContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
    }
}