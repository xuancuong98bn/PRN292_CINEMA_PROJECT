using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cinema.Areas.Admin.Models;
using cinema.Contexts;
using cinema.Models;

namespace cinema.Areas.Admin.Controllers
{
    public class BookingController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Admin/Booking
        public ActionResult Index()
        {
            //join time + room -> slot
            var slotInfo = from slot in db.Slots
                           join time in db.Timeslots on slot.TimeslotID equals time.ID
                           join r in db.Rooms on slot.RoomID equals r.ID
                           select new
                           {
                               slot.ID,
                               r.Name,
                               time.BeginTime,
                               time.EndTime
                           };

            //join film and slot -> showtime
            var showtimeInfo2 = from showtime in db.Showtimes
                                join film in db.Films on showtime.FilmID equals film.ID
                                join slot in slotInfo on showtime.SlotID equals slot.ID
                                select new
                                {
                                    showtime.ID,
                                    film.Title,
                                    slot.Name,  //room name
                                    slot.BeginTime,
                                    slot.EndTime
                                };

            var ticketInfo = from ticket in db.Tickets
                             join st in showtimeInfo2 on ticket.ShowtimeID equals st.ID
                             join seat in db.Seats on ticket.SeatID equals seat.ID
                             select new
                             {
                                 ticket.ID,
                                 st.Title,
                                 st.Name,
                                 st.BeginTime,
                                 st.EndTime, 
                                 seat.Rowth,
                                 seat.Columnth,
                                 ticket.Price
                             };
            var user_ticketInfo = from ut in db.User_Tickets
                                  join ti in ticketInfo on ut.TicketID equals ti.ID
                                  join u in db.Users on ut.UserID equals u.ID
                                  select new
                                  {
                                      u.Fullname,
                                      ti.Title,
                                      ti.Name,//film
                                      ti.BeginTime,
                                      ti.EndTime,
                                      ti.Rowth,
                                      ti.Columnth,
                                      ti.Price,
                                      ut.Booktime

                                  };
            List<TicketBusiness> ticketBusinesses = new List<TicketBusiness>();
            foreach (var item in user_ticketInfo)
            {
                TicketBusiness tb = new TicketBusiness()
                {
                    CustomerName = item.Fullname,
                    Film = item.Title,
                    Room = item.Name,
                    BeginTime = item.BeginTime,
                    EndTime = item.EndTime,
                    SeateInfo = "Rowth-Column : " + item.Rowth + "-" + item.Columnth,
                    Booktime = item.Booktime,
                    Price = item.Price,
                };
                ticketBusinesses.Add(tb);
            }
            return View(ticketBusinesses);
        }

   

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
