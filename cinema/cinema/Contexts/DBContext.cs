using cinema.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cinema.Contexts
{
    public class DBContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Room_Seattype> Room_Seattypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Seattype> Seattypes { get; set; }
        public DbSet<Showtime> Showtimes { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Timeslot> Timeslots { get; set; }
        public DbSet<User_Ticket> User_Tickets { get; set; }
        public DbSet<User> Users { get; set; }
    }
}