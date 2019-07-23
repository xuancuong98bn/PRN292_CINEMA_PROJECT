using cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema.ModelsView
{
    public class BookingView
    {
        public Film Film { get; set; }
        public List<Slot> ListSlot { get; set; }
        public List<Timeslot> ListTimeSlot { get; set; }

        public BookingView()
        {
        }

        public BookingView(Film film, List<Slot> listSlot, List<Timeslot> listTimeSlot)
        {
            Film = film;
            ListSlot = listSlot;
            ListTimeSlot = listTimeSlot;
        }
    }
}