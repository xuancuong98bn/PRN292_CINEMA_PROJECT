using cinema.Contexts;
using cinema.Models;
using cinema.ModelsView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace cinema.Controllers
{
    public class BookController : Controller
    {
        DBContext db = new DBContext();
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Step1(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var listShowTime = db.Showtimes.Where(s => s.FilmID == id).ToList();
            if (listShowTime.Count == 0)
            {
                return HttpNotFound();
            }
            List<Slot> listSlot = new List<Slot>();
            List<Timeslot> listTimeSlot = new List<Timeslot>();
            foreach (var i in listShowTime)
            {
                Slot a = db.Slots.Find(i.SlotID);
                listSlot.Add(a);
                int b = a.TimeslotID;
                Timeslot c = db.Timeslots.Find(b);
                listTimeSlot.Add(c);
            }
            Film f = db.Films.Find(id);
            BookingView bkv = new BookingView(f, listShowTime, listSlot, listTimeSlot);
            return View(bkv);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Step2(int FilmID, int ShowtimeID, int RoomID)
        {
            if (ShowtimeID != 0 && RoomID != 0)
            {
                var CurrFilm = db.Films.Find(FilmID);
                Session.Add("ShowtimeID", ShowtimeID);
                Session.Add("RoomID", RoomID);
                Session.Add("CurrFilm", CurrFilm);
                ViewBag.SeatTypes = db.Seattypes.ToList();
                ViewBag.Room = db.Rooms.Find(RoomID);
                ViewBag.CurrFilm = CurrFilm;
                User user = (User)Session["user"];
                if (user != null)
                {
                    var listTicket = db.User_Tickets.Where(u => u.UserID == user.ID).ToList();
                    var listMySeat = new List<Ticket>();
                    foreach (var i in listTicket)
                    {
                        listMySeat.Add(db.Tickets.Find(i.TicketID));
                    }
                    ViewBag.ListMySeat = listMySeat.OrderBy(t => t.SeatID).ToList();
                }
                return View(db.Tickets.Where(t => t.ShowtimeID == ShowtimeID).ToList());
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

        [HttpGet]
        public ActionResult Step3()
        {
            TicketView tv = (TicketView)Session["TicketV"];
            User user = (User)Session["user"];
            if (user != null)
            {
                if (tv != null)
                {
                    return View(tv);
                }
                else
                {
                    return RedirectToAction("Index", "Movies");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Step3(int row, int column)
        {
            if (row != 0 && column != 0)
            {
                var roomID = (int)Session["RoomID"];
                var seat = db.Seats.Where(s => s.RoomID == roomID && s.Rowth == row && s.Columnth == column).SingleOrDefault();
                if (seat == null || seat.IsEnable == false)
                {
                    return RedirectToAction("Index", "Movies");
                }
                else
                {
                    int showtimeID = (int)Session["ShowtimeID"];
                    var stPrice = db.Showtimes.Find(showtimeID).OriginPrice;
                    var seatPrice = db.Seattypes.Find(seat.SeattypeID).PlusPrice;
                    Ticket t = new Ticket() { ShowtimeID = showtimeID, SeatID = seat.ID, Status = 1, Price = stPrice + seatPrice };
                    TicketView tv = new TicketView(t);
                    Session.Add("TicketV", tv);
                    return View(tv);
                }
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Step4()
        {
            TicketView tv = (TicketView)Session["TicketV"];
            User user = (User)Session["user"];
            if (user != null)
            {
                if (tv != null)
                {
                    db.Tickets.Add(tv.Ticket);
                    db.SaveChanges();
                    var ticket = db.Tickets.Where(t => t.ShowtimeID == tv.Ticket.ShowtimeID && t.SeatID == tv.Ticket.SeatID).SingleOrDefault();
                    User_Ticket ut = new User_Ticket() { UserID = user.ID, TicketID = ticket.ID, IsEnable = true, Booktime = DateTime.Now };
                    db.User_Tickets.Add(ut);
                    db.SaveChanges();
                    Session.Remove("TicketV");
                    return View(tv);
                }
                else
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}