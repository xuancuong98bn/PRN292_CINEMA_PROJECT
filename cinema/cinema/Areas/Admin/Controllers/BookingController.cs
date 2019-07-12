using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cinema.Contexts;
using cinema.Models;

namespace cinema.Areas.Admin.Controllers
{
    /// <summary>
    /// index (viewlist)  - detail
    /// create : member's controller
    /// </summary>
    public class BookingController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Booking
        public ActionResult Index()
        {
            return View(db.User_Tickets.ToList());
        }

        // GET: Booking/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Ticket user_Ticket = db.User_Tickets.Find(id);
            if (user_Ticket == null)
            {
                return HttpNotFound();
            }
            return View(user_Ticket);
        }

        // GET: Booking/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Booking/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UserID,TicketID,Booktime,IsEnable")] User_Ticket user_Ticket)
        {
            if (ModelState.IsValid)
            {
                db.User_Tickets.Add(user_Ticket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user_Ticket);
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
