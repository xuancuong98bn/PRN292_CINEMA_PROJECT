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
        public ActionResult Step2(BookingView bkv, int ShowtimeID)
        {
            return View();
        }
    }
}