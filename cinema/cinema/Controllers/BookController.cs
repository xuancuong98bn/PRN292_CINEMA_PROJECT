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
                var seats = db.Seats.Where(s => s.RoomID == RoomID).ToList();
                ViewBag.SeatTypes = db.Seattypes.ToList();
                ViewBag.Room = db.Rooms.Find(RoomID);
                ViewBag.CurrFilm = CurrFilm;
                return View(seats);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Step3(int row, int column)
        {
            if (row != 0 && column != 0)
            {
                var roomID = (int) Session["RoomID"];
                var seat = db.Seats.Where(s => s.RoomID == roomID && s.Rowth == row && s.Columnth == column).SingleOrDefault();
                if (seat == null || seat.IsEnable == false)
                {
                    RedirectToAction("Index", "Movies");
                }
                else
                {

                }
                var CurrFilm = db.Films.Find(FilmID);
                Session.Add("ShowtimeID", ShowtimeID);
                Session.Add("RoomID", RoomID);
                Session.Add("CurrFilm", CurrFilm);
                var seats = db.Seats.Where(s => s.RoomID == RoomID).ToList();
                ViewBag.SeatTypes = db.Seattypes.ToList();
                ViewBag.Room = db.Rooms.Find(RoomID);
                ViewBag.CurrFilm = CurrFilm;
                return View(seats);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }
    }
}