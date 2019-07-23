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
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var listSlotID = db.Showtimes.Where(s => s.FilmID == id).Select(s => s.SlotID).ToList();
            if (listSlotID.Count == 0)
            {
                return HttpNotFound();
            }
            List<Slot> listSlot = new List<Slot>();
            List<Timeslot> listTimeSlot = new List<Timeslot>();
            foreach (int i in listSlotID)
            {
                Slot a = db.Slots.Find(i);
                listSlot.Add(a);
                int b = a.TimeslotID;
                Timeslot c = db.Timeslots.Find(b);
                listTimeSlot.Add(c);
            }
            Film f = db.Films.Find(id);
            BookingView bkv = new BookingView(f, listSlot, listTimeSlot);
            return View(bkv);
        }
    }
}