using cinema.Contexts;
using cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.ModelsView
{
    public class TicketView
    {
        public Ticket Ticket { get; set; }
        public Showtime Showtime { get; set; }
        public Film Film { get; set; }
        public Slot Slot { get; set; }
        public Room Room { get; set; }
        public Timeslot Timeslot { get; set; }
        public Seat Seat { get; set; }
        public Seattype Seattype { get; set; }

        DBContext db = new DBContext();

        public TicketView(Ticket ticket)
        {
            Ticket = ticket;
            Showtime = db.Showtimes.Find(ticket.ShowtimeID);
            Film = db.Films.Find(Showtime.FilmID);
            Slot = db.Slots.Find(Showtime.SlotID);
            Room = db.Rooms.Find(Slot.RoomID);
            Timeslot = db.Timeslots.Find(Slot.TimeslotID);
            Seat = db.Seats.Find(ticket.SeatID);
            Seattype = db.Seattypes.Find(Seat.SeattypeID);
        }
    }
}